using CSPOS.Domain.Enums;
using System;

namespace CSPOS.Domain.DTO
{
    public class DtoCatalogItem
    {
        public int CatalogItemID { get; set; }
        public CatalogCategories CategoryID { get; set; }
        public CatalogMakers MakerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int InStockNum { get; set; }
        public string OrigCountry { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int? Warranty { get; set; }
        public CatalogConditions? ConditionID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Deleted { get; set; }
        public CatalogItemTypes ItemType { get; set; }
    }
}
