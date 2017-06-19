using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmOrderItem : Form
    {
        public FrmOrderItem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are not enough items in stock for selected spare part. The quantity field will be updated accordingly.", "Adding spare part", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
