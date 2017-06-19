using CSPOS.Domain.Delegates;
using CSPOS.Domain.Enums;
using System;

namespace CSPOS.Domain.Models
{
    public class DmNewCatalogItem : DmCatalogItem
    {
        public static LoadCatalogItemForm LoadCatalogItemFormDelegate;

        private int? _warranty;
        public int? Warranty { get { return _warranty; } set { _warranty = value; } }

        public DmNewCatalogItem()
        {
            ItemType = Enums.CatalogItemTypes.NewCatalogItem.ConvertToInt();
        }

        public override void EditDetails()
        {
            LoadCatalogItemFormDelegate?.Invoke(this);
        }

        public static DmCatalogItem InitializeNew()
        {
            return new DmNewCatalogItem()
            {
                _itemType = CatalogItemTypes.NewCatalogItem.ConvertToInt(),
                _manufactureDate = DateTime.Now,
                _modifiedDate = DateTime.Now,
                _warranty = 0,
                _deleted = false,
            };
        }
    }
}
