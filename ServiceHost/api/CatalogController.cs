using CSPOS.DAL;
using CSPOS.Domain.DTO;
using CSPOS.Domain.Enums;
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
        [Route("categories")]
        public IHttpActionResult GetCatalogCategories()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.catalogcategories
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoCatalogCategory>(x));

                return Json(items ?? new List<DtoCatalogCategory>());
            }
        }

        [HttpGet]
        [Route("makers")]
        public IHttpActionResult GetCatalogMaker()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.catalogmakers
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoCatalogMaker>(x));

                return Json(items ?? new List<DtoCatalogMaker>());
            }
        }

        [HttpGet]
        [Route("conditions")]
        public IHttpActionResult GetCatalogConditions()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.catalogconditions
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoCatalogCondition>(x));

                return Json(items ?? new List<DtoCatalogCondition>());
            }
        }

        [HttpGet]
        [Route("types")]
        public IHttpActionResult GetCatalogTypes()
        {
            using (var dbContext = new csposEntities())
            {
                var items = dbContext.catalogtypes
                    .Take(1000)
                    .ToList()
                    .Select(x => objMapper.Map<DtoCatalogType>(x));

                return Json(items ?? new List<DtoCatalogType>());
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

                    return Json(new { ResponseResult = newItem.CatalogItemID });
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

                    return Json(new { ResponseResult = dbContext.SaveChanges() });
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
            item.CatalogItemID = update.CatalogItemID;
            item.MakerID = update.MakerID.ConvertToInt();
            item.Name = update.Name;
            item.Description = update.Description;
            item.Price = update.Price;
            item.InStockNum = update.InStockNum;
            item.OrigCountry = update.OrigCountry;
            item.ManufactureDate = update.ManufactureDate;
            item.ModifiedDate = DateTime.Now;

            if (update.ConditionID.HasValue)
            {
                item.ConditionID = update.ConditionID.ConvertToInt();
            }

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
                        return Json(new { ResponseResult = 0 });
                    }

                    item.Deleted = true;

                    return Json(new { ResponseResult = dbContext.SaveChanges() });
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
