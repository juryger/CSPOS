using CSPOS.DAL;
using CSPOS.Domain.DTO;
using ServiceHost.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;

namespace ServiceHost
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        private TinyObjectMapperHelper objMapper;

        public OrdersController()
        {
            objMapper = TinyObjectMapperHelper.Instance;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetOrders()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.orders
                    .Where(o => o.Deleted == false)
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoOrder>(x));

                return Json(items ?? new List<DtoOrder>());
            }
        }

        [HttpGet]
        [Route("{orderId}")]
        public IHttpActionResult GetOrderById([FromUri] int orderId)
        {
            using (var dbContext = new csposEntities())
            {
                var item = dbContext.orders
                    .Include(o => o.orderitems)
                    .FirstOrDefault(o => o.OrderID == orderId && o.Deleted == false);

                if (item == null)
                    return NotFound();

                return Json(objMapper.Map<DtoOrder>(item));

            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult CreateOrder([FromBody] DtoOrder item)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    item.OrderStatusID = CSPOS.Domain.Enums.OrderStatues.NotApproved;

                    var newItem = dbContext.orders
                        .Add(objMapper.Map<order>(item));

                    dbContext.SaveChanges();

                    return Json(objMapper.Map<DtoOrder>(item));
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to place new order: " + ex.Message);
                }
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult UpdateOrder([FromBody] DtoOrder update)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    var item = dbContext.orders
                        .Include(o => o.orderitems)
                        .FirstOrDefault(c => c.OrderID == update.OrderID);

                    if (item == null)
                    {
                        return BadRequest("Order does not exist any more.");
                    }

                    UpdateOrderInternal(item, update);

                    return Json(new { Count = dbContext.SaveChanges() });
                }
                catch (DbUpdateConcurrencyException /*cex*/)
                {
                    return BadRequest("Unable to update order because it has been changed by other user. Try again later.");
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to update catatlog item: " + ex.Message);
                }
            }
        }

        private void UpdateOrderInternal(order item, DtoOrder update)
        {
            var orderItemsToRemove = new List<orderitem>();

            foreach (var oi in item.orderitems)
            {
                var uoi = update.navOrderItems.FirstOrDefault(x => x.CatalogItemID == oi.CatalogItemID);
                if (uoi == null)
                {
                    orderItemsToRemove.Add(oi);
                    continue;
                }

                oi.Price = uoi.Price;
                oi.Quantity = uoi.Quantity;
            }

            // Process deleted order items
            orderItemsToRemove.ForEach(x => item.orderitems.Remove(x));


            // Process added oreder items
            update.navOrderItems
                .ToList()
                .ForEach(x =>
                {
                    if (item.orderitems.FirstOrDefault(y => y.CatalogItemID == x.CatalogItemID) == null)
                        item.orderitems.Add(objMapper.Map<orderitem>(x));
                });
        }

        [HttpDelete]
        [Route("{itemId}")]
        public IHttpActionResult DeleteOrder([FromUri] int itemId)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    var item = dbContext.orders.FirstOrDefault(o => o.OrderID == itemId);
                    if (item == null)
                    {
                        return Json(new { Count = 0 });
                    }

                    item.Deleted = true;

                    return Json(new { Count = dbContext.SaveChanges() });
                }
                catch (DbUpdateConcurrencyException /*cex*/)
                {
                    return BadRequest("Unable to delete order because it has been changed by other user. Try again later.");
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to delete order: " + ex.Message);
                }
            }
        }
    }
}
