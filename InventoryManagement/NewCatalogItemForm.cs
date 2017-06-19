using CSPOS.Domain.Models;
using System;

namespace InventoryManagement
{
    public partial class NewCatalogItemForm : CatalogItemForm
    {
        private static readonly NewCatalogItemForm _instance = new NewCatalogItemForm();

        public static NewCatalogItemForm Instance
        {
            get
            {
                return _instance;
            }
        }

        private NewCatalogItemForm() : base()
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

            nudWarranty.Value = (_catalogItem as DmNewCatalogItem).Warranty.Value;
        }

        protected override void PushData()
        {
            base.PushData();

            (_catalogItem as DmNewCatalogItem).Warranty = Convert.ToInt32(nudWarranty.Value);
        }
    }
}
