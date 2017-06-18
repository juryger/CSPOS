namespace CSPOS.Domain.Models
{
    public class DmOrderItem
    {
        public int OrderID { get; set; }
        public int CatalogItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public DmCatalogItem navCatalog { get; set; }
    }
}
