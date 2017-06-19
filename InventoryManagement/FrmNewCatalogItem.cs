using CSPOS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmNewCatalogItem : FrmCatalogItem
    {
        private static readonly FrmNewCatalogItem _instance = new FrmNewCatalogItem();

        public static FrmNewCatalogItem Instance
        {
            get
            {
                return _instance;
            }
        }

        private FrmNewCatalogItem() : base()
        {
            InitializeComponent();
        }

        public DialogResult Run(DmCatalogItem pCatalogItem,
            IList<DmCatalogCategory> pCategories,
            IList<DmCatalogMaker> pMakers,
            IList<DmCatalogCondition> pConditions)
        {
            _catalogItem = pCatalogItem;

            base.Categories.DataSource = pCategories;
            base.Categories.DisplayMember = nameof(DmCatalogCategory.Name);

            base.Makers.DataSource = pMakers;
            base.Makers.DisplayMember = nameof(DmCatalogMaker.Name);

            UpdateForm();

            return ShowDialog();
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
