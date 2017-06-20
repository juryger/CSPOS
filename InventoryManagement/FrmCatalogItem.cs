using CSPOS.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmCatalogItem : Form
    {
        protected DmCatalogItem _catalogItem;
        protected IList<DmCatalogCategory> _dsCategories;
        protected IList<DmCatalogMaker> _dsMakers;

        protected FrmCatalogItem()
        {
            InitializeComponent();

            cbxCategory.DisplayMember = nameof(DmCatalogCategory.Name);
            cbxCategory.ValueMember = nameof(DmCatalogCategory.CatalogCategoryID);

            cbxMaker.DisplayMember = nameof(DmCatalogMaker.Name);
            cbxMaker.ValueMember = nameof(DmCatalogMaker.CatalogMakerID);
        }

        protected virtual void UpdateForm()
        {
            tbxCatalogItemId.Text = _catalogItem.CatalogItemID.ToString();
            tbxName.Text = _catalogItem.Name;
            tbxDescription.Text = _catalogItem.Description;
            nudPrice.Value = _catalogItem.Price;
            nudInStock.Value = _catalogItem.InStockNum;
            dtpManufactureDate.Value = _catalogItem.ManufactureDate;


            cbxCategory.DataSource = new BindingList<DmCatalogCategory>(_dsCategories);
            cbxCategory.SelectedValue = _catalogItem.CategoryID;

            cbxMaker.DataSource = new BindingList<DmCatalogMaker>(_dsMakers);
            cbxMaker.SelectedValue = _catalogItem.MakerID;
        }

        protected virtual void PushData()
        {
            _catalogItem.Name = tbxName.Text;
            _catalogItem.Description = tbxDescription.Text;
            _catalogItem.CategoryID = (cbxCategory.SelectedItem as DmCatalogCategory).CatalogCategoryID;
            _catalogItem.MakerID = (cbxMaker.SelectedItem as DmCatalogMaker).CatalogMakerID;
            _catalogItem.Price = nudPrice.Value;
            _catalogItem.InStockNum = Convert.ToInt32(nudInStock.Value);
            _catalogItem.ManufactureDate = dtpManufactureDate.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PushData();
            DialogResult = DialogResult.OK;
        }
    }
}
