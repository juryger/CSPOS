using CSPOS.Domain.Delegates;
using CSPOS.Domain.Enums;
using System;

namespace CSPOS.Domain.Models
{
    public class DmUsedCatalogItem : DmCatalogItem
    {
        public static LoadCatalogItemForm LoadCatalogItemFormDelegate;

        private int? _conditionID;
        public int? ConditionID { get { return _conditionID; } set { _conditionID = value; } }


        public DmUsedCatalogItem()
        {
            ItemType = Enums.CatalogItemTypes.UsedCatalogItem.ConvertToInt();
        }

        public override void EditDetails()
        {
            LoadCatalogItemFormDelegate?.Invoke(this);
        }

        public static DmCatalogItem InitializeNew()
        {
            return new DmUsedCatalogItem()
            {
                _itemType = CatalogItemTypes.NewCatalogItem.ConvertToInt(),
                _manufactureDate = DateTime.Now,
                _modifiedDate = DateTime.Now,
                _conditionID = CatalogConditions.Average.ConvertToInt(),
                _deleted = false,
            };
        }
    }
}
