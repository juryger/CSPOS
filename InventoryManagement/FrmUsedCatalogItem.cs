using CSPOS.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmUsedCatalogItem : FrmCatalogItem
    {
        private static readonly FrmUsedCatalogItem _instance = new FrmUsedCatalogItem();

        public static FrmUsedCatalogItem Instance
        {
            get
            {
                return _instance;
            }
        }

        private FrmUsedCatalogItem() : base()
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

            cbxCondition.DataSource = pConditions;
            cbxCondition.DisplayMember = nameof(DmCatalogCondition.Name);

            UpdateForm();

            return ShowDialog();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();

            var dsCondition = cbxCondition.DataSource as IList<DmCatalogCondition>;
            if (dsCondition != null)
            {
                var itemToSelect = dsCondition.FirstOrDefault(x =>
                    x.CatalogConditionID == (_catalogItem as DmUsedCatalogItem).ConditionID);
                cbxCondition.SelectedValue = itemToSelect;
            }
            cbxCondition.SelectedValue = (_catalogItem as DmUsedCatalogItem).ConditionID.Value;
        }

        protected override void PushData()
        {
            base.PushData();

            (_catalogItem as DmUsedCatalogItem).ConditionID = (cbxCondition.SelectedValue as DmCatalogCondition).CatalogConditionID;
        }

    }
}
