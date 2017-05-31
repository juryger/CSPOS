using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManagementForm : Form
    {
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

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
