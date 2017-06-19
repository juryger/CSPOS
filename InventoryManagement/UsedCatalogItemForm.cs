using CSPOS.Domain.Models;
using System;

namespace InventoryManagement
{
    public partial class UsedCatalogItemForm : CatalogItemForm
    {
        private static readonly UsedCatalogItemForm _instance = new UsedCatalogItemForm();

        public static UsedCatalogItemForm Instance
        {
            get
            {
                return _instance;
            }
        }

        private UsedCatalogItemForm() : base()
        {
            InitializeComponent();
        }

        public void Run(DmCatalogItem pCatalogItem)
        {
            _catalogItem = pCatalogItem;
            UpdateForm();
            ShowDialog();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();

            cbxCondition.SelectedValue = (_catalogItem as DmUsedCatalogItem).ConditionID.Value;
        }

        protected override void PushData()
        {
            base.PushData();

            (_catalogItem as DmUsedCatalogItem).ConditionID = Convert.ToInt32(cbxCondition.SelectedValue);
        }

    }
}
