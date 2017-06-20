namespace CSPOS.Domain.Models
{
    public class DmOrderItem
    {
        public int OrderID { get; set; }
        public int CatalogItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public DmCatalogItem navCatalog { get; set; }

        public string Summary
        {
            get
            {
                return string.Format("catalog item: {0}, num: {1}, price: {2}", CatalogItemID, Quantity, Price);
            }
        }
    }
}
