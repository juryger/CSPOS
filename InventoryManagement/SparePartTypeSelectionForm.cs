﻿using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class SparePartTypeSelectionForm : Form
    {
        public SparePartTypeSelectionForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var spf = new BrandNewSparePartForm();
                spf.Show();
            }
            else
            {
                var spf = new UsedSparePartForm();
                spf.Show();
            }
        }
    }
}