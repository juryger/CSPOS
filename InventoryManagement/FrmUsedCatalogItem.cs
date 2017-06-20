using CSPOS.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmUsedCatalogItem : FrmCatalogItem
    {
        protected IList<DmCatalogCondition> _dsConditions;

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

            cbxConditions.DisplayMember = nameof(DmCatalogCondition.Name);
            cbxConditions.ValueMember = nameof(DmCatalogCondition.CatalogConditionID);
        }

        public DialogResult Run(DmCatalogItem pCatalogItem,
            IList<DmCatalogCategory> pCategories,
            IList<DmCatalogMaker> pMakers,
            IList<DmCatalogCondition> pConditions)
        {
            base._catalogItem = pCatalogItem;
            base._dsCategories = pCategories;
            base._dsMakers = pMakers;
            this._dsConditions = pConditions;

            UpdateForm();

            return ShowDialog();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();

            cbxConditions.DataSource = new BindingList<DmCatalogCondition>(_dsConditions);
            cbxConditions.SelectedValue = (_catalogItem as DmUsedCatalogItem).ConditionID;
        }

        protected override void PushData()
        {
            base.PushData();

            (_catalogItem as DmUsedCatalogItem).ConditionID = (cbxConditions.SelectedItem as DmCatalogCondition).CatalogConditionID;
        }

    }
}
