using CSPOS.Domain.Delegates;
using CSPOS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public override DialogResult EditDetails(
            IList<DmCatalogCategory> pCategories,
            IList<DmCatalogMaker> pMakers,
            IList<DmCatalogCondition> pConditions)
        {
            return LoadCatalogItemFormDelegate == null ?
                DialogResult.Cancel :
                LoadCatalogItemFormDelegate.Invoke(this, pCategories, pMakers, pConditions);
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

        public override DmCatalogItem MakeCopy()
        {
            return new DmUsedCatalogItem()
            {
                _catalogItemID = this.CatalogItemID,
                _categoryID = this.CategoryID,
                _makerID = this.MakerID,
                _name = this.Name,
                _description = this.Description,
                _price = this.Price,
                _inStockNum = this.InStockNum,
                _origCountry = this.OrigCountry,
                _manufactureDate = this.ManufactureDate,
                _modifiedDate = this.ModifiedDate,
                _itemType = this.ItemType,
                _deleted = this.Deleted,
                _conditionID = this.ConditionID,
            };
        }

        public override void SyncState(DmCatalogItem state)
        {
            this.CatalogItemID = state.CatalogItemID;
            this.CategoryID = state.CategoryID;
            this.MakerID = state.MakerID;
            this.Name = state.Name;
            this.Description = state.Description;
            this.Price = state.Price;
            this.InStockNum = state.InStockNum;
            this.OrigCountry = state.OrigCountry;
            this.ManufactureDate = state.ManufactureDate;
            this.ModifiedDate = state.ModifiedDate;
            this.ItemType = state.ItemType;
            this.Deleted = state.Deleted;
            this.ConditionID = (state as DmUsedCatalogItem).ConditionID;
        }
    }
}
