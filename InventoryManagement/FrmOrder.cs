using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var oif = new FrmOrderItem();
            oif.Show();
        }
    }
}
