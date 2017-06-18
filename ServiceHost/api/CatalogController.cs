using CSPOS.DAL;
using CSPOS.Domain.DTO;
using ServiceHost.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;

namespace ServiceHost.api
{
    [RoutePrefix("api/catalog")]
    public class CatalogController : ApiController
    {
        private TinyObjectMapperHelper objMapper;

        public CatalogController()
        {
            objMapper = TinyObjectMapperHelper.Instance;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCatalog()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.catalogs
                    .Where(ci => ci.Deleted == false)
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoCatalogItem>(x));

                return Json(items ?? new List<DtoCatalogItem>());
            }
        }

        [HttpGet]
        [Route("{itemId}")]
        public IHttpActionResult GetCatalogItemById([FromUri] int itemId)
        {
            using (var dbContext = new csposEntities())
            {
                var item = dbContext.catalogs
                    .FirstOrDefault(ci => ci.CatalogItemID == itemId && ci.Deleted == false);

                if (item == null)
                    return NotFound();

                return Json(objMapper.Map<DtoCatalogItem>(item));
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult CreateCatalogItem([FromBody] DtoCatalogItem item)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    item.ModifiedDate = DateTime.Now;
                    var newItem = dbContext.catalogs
                        .Add(objMapper.Map<catalog>(item));

                    dbContext.SaveChanges();

                    return Json(new { Id = newItem.CatalogItemID });
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to add new catatlog item: " + ex.Message);
                }
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult UpdateCatalogItem([FromBody] DtoCatalogItem update)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    var item = dbContext.catalogs.FirstOrDefault(c => c.CatalogItemID == update.CatalogItemID);
                    if (item == null)
                    {
                        return BadRequest("Catalog item does not exist any more.");
                    }

                    UpdateCatalogItemInternal(item, update);

                    return Json(new { Count = dbContext.SaveChanges() });
                }
                catch (DbUpdateConcurrencyException /*cex*/)
                {
                    return BadRequest("Unable to update catatlog item because it has been changed by other user. Try again later.");
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to update catatlog item: " + ex.Message);
                }
            }
        }

        private void UpdateCatalogItemInternal(catalog item, DtoCatalogItem update)
        {
            item.Name = update.Name;
            item.Description = update.Description;
            item.InStockNum = update.InStockNum;
            item.ManufactureDate = update.ManufactureDate;
            item.ModifiedDate = DateTime.Now;
            item.OrigCountry = update.OrigCountry;
            item.Price = update.Price;
            item.Warranty = update.Warranty;
        }

        [HttpDelete]
        [Route("{itemId}")]
        public IHttpActionResult DeleteCatalogItem([FromUri] int itemId)
        {
            using (var dbContext = new csposEntities())
            {
                try
                {
                    var item = dbContext.catalogs.FirstOrDefault(c => c.CatalogItemID == itemId);
                    if (item == null)
                    {
                        return Json(new { Count = 0 });
                    }

                    item.Deleted = true;

                    return Json(new { Count = dbContext.SaveChanges() });
                }
                catch (DbUpdateConcurrencyException /*cex*/)
                {
                    return BadRequest("Unable to delete catatlog item because it has been changed by other user. Try again later.");
                }
                catch (DataException ex)
                {
                    return BadRequest("Unable to delete catatlog item: " + ex.Message);
                }
            }
        }
    }
}
