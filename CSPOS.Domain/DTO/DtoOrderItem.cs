namespace CSPOS.Domain.DTO
{
    public class DtoOrderItem
    {
        public int OrderID { get; set; }
        public int CatalogItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public DtoCatalogItem navCatalogItem { get; set; }
    }
}
