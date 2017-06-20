namespace InventoryManagement
{
    partial class FrmOrder
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
            this.orderPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.tbxOrderId = new System.Windows.Forms.TextBox();
            this.lbCreated = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderItemsPanel = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lbxOrderItems = new System.Windows.Forms.ListBox();
            this.txbCreatedDate = new System.Windows.Forms.TextBox();
            this.orderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.orderItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.txbCreatedDate);
            this.orderPanel.Controls.Add(this.cbxStatus);
            this.orderPanel.Controls.Add(this.lbStatus);
            this.orderPanel.Controls.Add(this.btnCancel);
            this.orderPanel.Controls.Add(this.btnSave);
            this.orderPanel.Controls.Add(this.tbxCustomer);
            this.orderPanel.Controls.Add(this.tbxOrderId);
            this.orderPanel.Controls.Add(this.lbCreated);
            this.orderPanel.Controls.Add(this.lbCustomer);
            this.orderPanel.Controls.Add(this.lbOrderNo);
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderPanel.Location = new System.Drawing.Point(0, 0);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(299, 333);
            this.orderPanel.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(164, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.Location = new System.Drawing.Point(72, 40);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(200, 20);
            this.tbxCustomer.TabIndex = 13;
            // 
            // tbxOrderId
            // 
            this.tbxOrderId.Location = new System.Drawing.Point(72, 12);
            this.tbxOrderId.Name = "tbxOrderId";
            this.tbxOrderId.ReadOnly = true;
            this.tbxOrderId.Size = new System.Drawing.Size(200, 20);
            this.tbxOrderId.TabIndex = 12;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Location = new System.Drawing.Point(16, 74);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(44, 13);
            this.lbCreated.TabIndex = 10;
            this.lbCreated.Text = "Created";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(16, 47);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(51, 13);
            this.lbCustomer.TabIndex = 9;
            this.lbCustomer.Text = "Customer";
            // 
            // lbOrderNo
            // 
            this.lbOrderNo.AutoSize = true;
            this.lbOrderNo.Location = new System.Drawing.Point(16, 19);
            this.lbOrderNo.Name = "lbOrderNo";
            this.lbOrderNo.Size = new System.Drawing.Size(14, 13);
            this.lbOrderNo.TabIndex = 8;
            this.lbOrderNo.Text = "#";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderItemsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 333);
            this.panel1.TabIndex = 9;
            // 
            // orderItemsPanel
            // 
            this.orderItemsPanel.Controls.Add(this.lbxOrderItems);
            this.orderItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.orderItemsPanel.Name = "orderItemsPanel";
            this.orderItemsPanel.Size = new System.Drawing.Size(364, 333);
            this.orderItemsPanel.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(17, 102);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 18;
            this.lbStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(73, 94);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(199, 21);
            this.cbxStatus.TabIndex = 19;
            // 
            // lbxOrderItems
            // 
            this.lbxOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOrderItems.FormattingEnabled = true;
            this.lbxOrderItems.Location = new System.Drawing.Point(0, 0);
            this.lbxOrderItems.Name = "lbxOrderItems";
            this.lbxOrderItems.Size = new System.Drawing.Size(364, 333);
            this.lbxOrderItems.TabIndex = 1;
            // 
            // txbCreatedDate
            // 
            this.txbCreatedDate.Location = new System.Drawing.Point(72, 66);
            this.txbCreatedDate.Name = "txbCreatedDate";
            this.txbCreatedDate.ReadOnly = true;
            this.txbCreatedDate.Size = new System.Drawing.Size(200, 20);
            this.txbCreatedDate.TabIndex = 20;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(663, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.orderItemsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.TextBox tbxOrderId;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbOrderNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel orderItemsPanel;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ListBox lbxOrderItems;
        private System.Windows.Forms.TextBox txbCreatedDate;
    }
}