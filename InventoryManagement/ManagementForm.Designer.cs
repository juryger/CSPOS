namespace InventoryManagement
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tcContent = new System.Windows.Forms.TabControl();
            this.tpCatalog = new System.Windows.Forms.TabPage();
            this.catalogGridPanel = new System.Windows.Forms.Panel();
            this.catalogSideBarPanel = new System.Windows.Forms.Panel();
            this.btnCatalogFilter = new System.Windows.Forms.Button();
            this.lbMaker = new System.Windows.Forms.Label();
            this.cbxMaker = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersSidebarPanel = new System.Windows.Forms.Panel();
            this.btnOrderFilter = new System.Windows.Forms.Button();
            this.cbxOrderCustomer = new System.Windows.Forms.ComboBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lbCondition = new System.Windows.Forms.Label();
            this.cbxCondition = new System.Windows.Forms.ComboBox();
            this.lbxCatalog = new System.Windows.Forms.ListBox();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.ssMain.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tcContent.SuspendLayout();
            this.tpCatalog.SuspendLayout();
            this.catalogGridPanel.SuspendLayout();
            this.catalogSideBarPanel.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ordersSidebarPanel.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssMain.Location = new System.Drawing.Point(0, 285);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(490, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Total count: #";
            // 
            // tsContainer
            // 
            this.tsContainer.BottomToolStripPanelVisible = false;
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.contentPanel);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(490, 260);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.LeftToolStripPanelVisible = false;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.RightToolStripPanelVisible = false;
            this.tsContainer.Size = new System.Drawing.Size(490, 285);
            this.tsContainer.TabIndex = 6;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsMain);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.tcContent);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(490, 260);
            this.contentPanel.TabIndex = 8;
            // 
            // tcContent
            // 
            this.tcContent.Controls.Add(this.tpCatalog);
            this.tcContent.Controls.Add(this.tpOrders);
            this.tcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcContent.Location = new System.Drawing.Point(0, 0);
            this.tcContent.Name = "tcContent";
            this.tcContent.SelectedIndex = 0;
            this.tcContent.Size = new System.Drawing.Size(490, 260);
            this.tcContent.TabIndex = 7;
            // 
            // tpCatalog
            // 
            this.tpCatalog.Controls.Add(this.catalogGridPanel);
            this.tpCatalog.Controls.Add(this.catalogSideBarPanel);
            this.tpCatalog.Location = new System.Drawing.Point(4, 22);
            this.tpCatalog.Name = "tpCatalog";
            this.tpCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tpCatalog.Size = new System.Drawing.Size(482, 234);
            this.tpCatalog.TabIndex = 0;
            this.tpCatalog.Text = "Catalog";
            this.tpCatalog.UseVisualStyleBackColor = true;
            // 
            // catalogGridPanel
            // 
            this.catalogGridPanel.Controls.Add(this.lbxCatalog);
            this.catalogGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogGridPanel.Location = new System.Drawing.Point(3, 3);
            this.catalogGridPanel.Name = "catalogGridPanel";
            this.catalogGridPanel.Size = new System.Drawing.Size(326, 228);
            this.catalogGridPanel.TabIndex = 9;
            // 
            // catalogSideBarPanel
            // 
            this.catalogSideBarPanel.AutoScroll = true;
            this.catalogSideBarPanel.Controls.Add(this.lbCondition);
            this.catalogSideBarPanel.Controls.Add(this.cbxCondition);
            this.catalogSideBarPanel.Controls.Add(this.btnCatalogFilter);
            this.catalogSideBarPanel.Controls.Add(this.lbMaker);
            this.catalogSideBarPanel.Controls.Add(this.cbxMaker);
            this.catalogSideBarPanel.Controls.Add(this.lbCategory);
            this.catalogSideBarPanel.Controls.Add(this.cbxCategory);
            this.catalogSideBarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.catalogSideBarPanel.Location = new System.Drawing.Point(329, 3);
            this.catalogSideBarPanel.Name = "catalogSideBarPanel";
            this.catalogSideBarPanel.Size = new System.Drawing.Size(150, 228);
            this.catalogSideBarPanel.TabIndex = 8;
            // 
            // btnCatalogFilter
            // 
            this.btnCatalogFilter.Location = new System.Drawing.Point(6, 139);
            this.btnCatalogFilter.Name = "btnCatalogFilter";
            this.btnCatalogFilter.Size = new System.Drawing.Size(75, 23);
            this.btnCatalogFilter.TabIndex = 4;
            this.btnCatalogFilter.Text = "Apply";
            this.btnCatalogFilter.UseVisualStyleBackColor = true;
            // 
            // lbMaker
            // 
            this.lbMaker.AutoSize = true;
            this.lbMaker.Location = new System.Drawing.Point(3, 49);
            this.lbMaker.Name = "lbMaker";
            this.lbMaker.Size = new System.Drawing.Size(37, 13);
            this.lbMaker.TabIndex = 3;
            this.lbMaker.Text = "Maker";
            // 
            // cbxMaker
            // 
            this.cbxMaker.FormattingEnabled = true;
            this.cbxMaker.Location = new System.Drawing.Point(6, 65);
            this.cbxMaker.Name = "cbxMaker";
            this.cbxMaker.Size = new System.Drawing.Size(141, 21);
            this.cbxMaker.TabIndex = 2;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(3, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(49, 13);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(6, 25);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(141, 21);
            this.cbxCategory.TabIndex = 0;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.panel1);
            this.tpOrders.Controls.Add(this.ordersSidebarPanel);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(482, 234);
            this.tpOrders.TabIndex = 1;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 228);
            this.panel1.TabIndex = 3;
            // 
            // ordersSidebarPanel
            // 
            this.ordersSidebarPanel.Controls.Add(this.cbxOrderStatus);
            this.ordersSidebarPanel.Controls.Add(this.lbOrderStatus);
            this.ordersSidebarPanel.Controls.Add(this.btnOrderFilter);
            this.ordersSidebarPanel.Controls.Add(this.cbxOrderCustomer);
            this.ordersSidebarPanel.Controls.Add(this.lbCustomer);
            this.ordersSidebarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersSidebarPanel.Location = new System.Drawing.Point(329, 3);
            this.ordersSidebarPanel.Name = "ordersSidebarPanel";
            this.ordersSidebarPanel.Size = new System.Drawing.Size(150, 228);
            this.ordersSidebarPanel.TabIndex = 2;
            // 
            // btnOrderFilter
            // 
            this.btnOrderFilter.Location = new System.Drawing.Point(6, 96);
            this.btnOrderFilter.Name = "btnOrderFilter";
            this.btnOrderFilter.Size = new System.Drawing.Size(75, 23);
            this.btnOrderFilter.TabIndex = 2;
            this.btnOrderFilter.Text = "Apply";
            this.btnOrderFilter.UseVisualStyleBackColor = true;
            this.btnOrderFilter.Click += new System.EventHandler(this.btnOrderFilter_Click);
            // 
            // cbxOrderCustomer
            // 
            this.cbxOrderCustomer.FormattingEnabled = true;
            this.cbxOrderCustomer.Location = new System.Drawing.Point(6, 25);
            this.cbxOrderCustomer.Name = "cbxOrderCustomer";
            this.cbxOrderCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbxOrderCustomer.TabIndex = 1;
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(3, 9);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(51, 13);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "Customer";
            // 
            // tsMain
            // 
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripButton1,
            this.tsbDelete});
            this.tsMain.Location = new System.Drawing.Point(3, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(168, 25);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "tsMain";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Text = "Edit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Location = new System.Drawing.Point(3, 91);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(51, 13);
            this.lbCondition.TabIndex = 6;
            this.lbCondition.Text = "Condition";
            // 
            // cbxCondition
            // 
            this.cbxCondition.FormattingEnabled = true;
            this.cbxCondition.Location = new System.Drawing.Point(6, 107);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(141, 21);
            this.cbxCondition.TabIndex = 5;
            // 
            // lbxCatalog
            // 
            this.lbxCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxCatalog.FormattingEnabled = true;
            this.lbxCatalog.Location = new System.Drawing.Point(0, 0);
            this.lbxCatalog.Name = "lbxCatalog";
            this.lbxCatalog.Size = new System.Drawing.Size(326, 228);
            this.lbxCatalog.TabIndex = 0;
            // 
            // lbxOrders
            // 
            this.lbxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.Location = new System.Drawing.Point(0, 0);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(326, 228);
            this.lbxOrders.TabIndex = 0;
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Location = new System.Drawing.Point(7, 68);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxOrderStatus.TabIndex = 4;
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.AutoSize = true;
            this.lbOrderStatus.Location = new System.Drawing.Point(4, 52);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(37, 13);
            this.lbOrderStatus.TabIndex = 3;
            this.lbOrderStatus.Text = "Status";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 307);
            this.Controls.Add(this.tsContainer);
            this.Controls.Add(this.ssMain);
            this.Name = "ManagementForm";
            this.Text = "Management app";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.tcContent.ResumeLayout(false);
            this.tpCatalog.ResumeLayout(false);
            this.catalogGridPanel.ResumeLayout(false);
            this.catalogSideBarPanel.ResumeLayout(false);
            this.catalogSideBarPanel.PerformLayout();
            this.tpOrders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ordersSidebarPanel.ResumeLayout(false);
            this.ordersSidebarPanel.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TabControl tcContent;
        private System.Windows.Forms.TabPage tpCatalog;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Panel catalogGridPanel;
        private System.Windows.Forms.Panel catalogSideBarPanel;
        private System.Windows.Forms.Button btnCatalogFilter;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.ComboBox cbxMaker;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ordersSidebarPanel;
        private System.Windows.Forms.Button btnOrderFilter;
        private System.Windows.Forms.ComboBox cbxOrderCustomer;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.ComboBox cbxCondition;
        private System.Windows.Forms.ListBox lbxCatalog;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label lbOrderStatus;
    }
}

