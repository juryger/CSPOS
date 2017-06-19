using System;

namespace CSPOS.Domain.Models
{
    public abstract class DmCatalogItem
    {
        protected int _catalogItemID;
        protected int _categoryID;
        protected int _makerID;
        protected string _name;
        protected string _description;
        protected decimal _price;
        protected int _inStockNum;
        protected string _origCountry;
        protected DateTime _manufactureDate;
        protected DateTime _modifiedDate;
        protected int _itemType;
        protected bool _deleted;

        public int CatalogItemID { get { return _catalogItemID; } set { _catalogItemID = value; } }
        public int CategoryID { get { return _categoryID; } set { _categoryID = value; } }
        public int MakerID { get { return _makerID; } set { _makerID = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public int InStockNum { get { return _inStockNum; } set { _inStockNum = value; } }
        public string OrigCountry { get { return _origCountry; } set { _origCountry = value; } }
        public DateTime ManufactureDate { get { return _manufactureDate; } set { _manufactureDate = value; } }
        public DateTime ModifiedDate { get { return _modifiedDate; } set { _modifiedDate = value; } }
        public int ItemType { get { return _itemType; } protected set { _itemType = value; } }
        public bool Deleted { get { return _deleted; } set { _deleted = value; } }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _name + "\t" + _price.ToString("C") + "\t" + _modifiedDate.ToShortDateString();
        }
    }
}
