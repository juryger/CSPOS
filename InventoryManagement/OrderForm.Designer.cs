namespace InventoryManagement
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.orderPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.orderItemsToolbar = new System.Windows.Forms.Panel();
            this.orderItemsPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemIDOrderItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrderItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrderItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrderItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.orderItemsToolbar.SuspendLayout();
            this.orderItemsPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.checkBox2);
            this.orderPanel.Controls.Add(this.checkBox1);
            this.orderPanel.Controls.Add(this.button2);
            this.orderPanel.Controls.Add(this.button1);
            this.orderPanel.Controls.Add(this.textBox4);
            this.orderPanel.Controls.Add(this.textBox3);
            this.orderPanel.Controls.Add(this.textBox2);
            this.orderPanel.Controls.Add(this.textBox1);
            this.orderPanel.Controls.Add(this.label1);
            this.orderPanel.Controls.Add(this.label3);
            this.orderPanel.Controls.Add(this.label2);
            this.orderPanel.Controls.Add(this.lbCustomer);
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderPanel.Location = new System.Drawing.Point(0, 0);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(200, 333);
            this.orderPanel.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modified";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(21, 19);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(44, 13);
            this.lbCustomer.TabIndex = 8;
            this.lbCustomer.Text = "Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderItemsPanel);
            this.panel1.Controls.Add(this.orderItemsToolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 333);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(72, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Confirm order";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(72, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Cancel order";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // orderItemsToolbar
            // 
            this.orderItemsToolbar.Controls.Add(this.toolStrip1);
            this.orderItemsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderItemsToolbar.Location = new System.Drawing.Point(0, 0);
            this.orderItemsToolbar.Name = "orderItemsToolbar";
            this.orderItemsToolbar.Size = new System.Drawing.Size(463, 32);
            this.orderItemsToolbar.TabIndex = 0;
            // 
            // orderItemsPanel
            // 
            this.orderItemsPanel.Controls.Add(this.dataGridView1);
            this.orderItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsPanel.Location = new System.Drawing.Point(0, 32);
            this.orderItemsPanel.Name = "orderItemsPanel";
            this.orderItemsPanel.Size = new System.Drawing.Size(463, 301);
            this.orderItemsPanel.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "Edit";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDOrderItemColumn,
            this.NameOrderItemColumn,
            this.QuantityOrderItemColumn,
            this.PriceOrderItemColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemIDOrderItemColumn
            // 
            this.ItemIDOrderItemColumn.Frozen = true;
            this.ItemIDOrderItemColumn.HeaderText = "#";
            this.ItemIDOrderItemColumn.Name = "ItemIDOrderItemColumn";
            this.ItemIDOrderItemColumn.ReadOnly = true;
            // 
            // NameOrderItemColumn
            // 
            this.NameOrderItemColumn.HeaderText = "Name";
            this.NameOrderItemColumn.Name = "NameOrderItemColumn";
            this.NameOrderItemColumn.ReadOnly = true;
            // 
            // QuantityOrderItemColumn
            // 
            this.QuantityOrderItemColumn.HeaderText = "Quantity";
            this.QuantityOrderItemColumn.Name = "QuantityOrderItemColumn";
            this.QuantityOrderItemColumn.ReadOnly = true;
            // 
            // PriceOrderItemColumn
            // 
            this.PriceOrderItemColumn.HeaderText = "Price";
            this.PriceOrderItemColumn.Name = "PriceOrderItemColumn";
            this.PriceOrderItemColumn.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderPanel);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.orderItemsToolbar.ResumeLayout(false);
            this.orderItemsToolbar.PerformLayout();
            this.orderItemsPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel orderItemsPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDOrderItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrderItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrderItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrderItemColumn;
        private System.Windows.Forms.Panel orderItemsToolbar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}