using CSPOS.Domain.Enums;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmSparePartTypeSelection : Form
    {
        public FrmSparePartTypeSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public CatalogItemTypes GetAnswer()
        {
            return rbtnNewItem.Checked ?
                CatalogItemTypes.NewCatalogItem :
                CatalogItemTypes.UsedCatalogItem;
        }
    }
}
