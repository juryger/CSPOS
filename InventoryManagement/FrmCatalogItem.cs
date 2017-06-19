using CSPOS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmCatalogItem : Form
    {
        protected DmCatalogItem _catalogItem;

        protected FrmCatalogItem()
        {
            InitializeComponent();

            var cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-NZ");
            dtpManufactureDate.Format = DateTimePickerFormat.Custom;
            var formats = dtpManufactureDate.Value.GetDateTimeFormats(cultureInfo);
            dtpManufactureDate.CustomFormat = formats[11];
        }

        public ComboBox Categories
        {
            get { return cbxCategory; }
        }

        public ComboBox Makers
        {
            get { return cbxMaker; }
        }

        protected virtual void UpdateForm()
        {
            tbxName.Text = _catalogItem.Name;
            tbxDescription.Text = _catalogItem.Description;
            nudPrice.Value = _catalogItem.Price;
            nudInStock.Value = _catalogItem.InStockNum;
            dtpManufactureDate.Value = _catalogItem.ManufactureDate;

            var dsCategory = cbxCategory.DataSource as IList<DmCatalogCategory>;
            if (dsCategory != null)
            {
                var itemToSelect = dsCategory.FirstOrDefault(x => x.CatalogCategoryID == _catalogItem.CategoryID);
                cbxCategory.SelectedValue = itemToSelect;
            }

            var dsMaker = cbxMaker.DataSource as IList<DmCatalogMaker>;
            if (dsMaker != null)
            {
                var itemToSelect = dsMaker.FirstOrDefault(x => x.CatalogMakerID == _catalogItem.MakerID);
                cbxMaker.SelectedValue = itemToSelect;
            }
        }

        protected virtual void PushData()
        {
            _catalogItem.Name = tbxName.Text;
            _catalogItem.Description = tbxDescription.Text;
            _catalogItem.CategoryID = (cbxCategory.SelectedValue as DmCatalogCategory).CatalogCategoryID;
            _catalogItem.MakerID = (cbxMaker.SelectedValue as DmCatalogMaker).CatalogMakerID;
            _catalogItem.Price = nudPrice.Value;
            _catalogItem.InStockNum = Convert.ToInt32(nudInStock.Value);
            _catalogItem.ManufactureDate = dtpManufactureDate.Value;
        }
    }
}
