using CSPOS.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManagementForm : Form
    {
        private List<DtoCatalogItem> _dataSource;

        public ManagementForm()
        {
            InitializeComponent();
        }

        private void rightSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            var sf = new SparePartTypeSelectionForm();
            sf.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Deleting item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            var of = new OrderForm();
            of.Show();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            lbxCatalog.DataSource = null;
            ServiceClient.GetCatalogAsync()
                .ContinueWith(t =>
                {
                    try
                    {
                        lbxCatalog.Invoke(new Action<List<DtoCatalogItem>>(BindListBox), t.Result);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action<string>(NotifyError),
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                });
        }

        private void BindListBox(List<DtoCatalogItem> dataSource)
        {
            _dataSource = dataSource;

            lbxCatalog.DataSource = _dataSource;
            lbxCatalog.DisplayMember = nameof(DtoCatalogItem.Name);
            lbxCatalog.ValueMember = nameof(DtoCatalogItem.CatalogItemID);
        }

        private void NotifyError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
