using CSPOS.Domain.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class CatalogItemForm : Form
    {
        protected DmCatalogItem _catalogItem;

        protected CatalogItemForm()
        {
            InitializeComponent();

            var cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("en-NZ");
            dtpManufactureDate.Format = DateTimePickerFormat.Custom;
            var formats = dtpManufactureDate.Value.GetDateTimeFormats(cultureInfo);
            dtpManufactureDate.CustomFormat = formats[11];
        }

        protected virtual void UpdateForm()
        {
            tbxName.Text = _catalogItem.Name;
            tbxDescription.Text = _catalogItem.Description;
            cbxCategory.SelectedValue = _catalogItem.CategoryID;
            cbxMaker.SelectedValue = _catalogItem.MakerID;
            nudPrice.Value = _catalogItem.Price;
            nudInStock.Value = _catalogItem.InStockNum;
            dtpManufactureDate.Value = _catalogItem.ManufactureDate;
        }

        protected virtual void PushData()
        {
            _catalogItem.Name = tbxName.Text;
            _catalogItem.Description = tbxDescription.Text;
            _catalogItem.CategoryID = Convert.ToInt32(cbxCategory.SelectedValue);
            _catalogItem.MakerID = Convert.ToInt32(cbxMaker.SelectedValue);
            _catalogItem.Price = nudPrice.Value;
            _catalogItem.InStockNum = Convert.ToInt32(nudInStock.Value);
            _catalogItem.ManufactureDate = dtpManufactureDate.Value;
        }
    }
}
