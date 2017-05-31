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
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.CatalogNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogInStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogSideBarPanel = new System.Windows.Forms.Panel();
            this.btnCatalogFilter = new System.Windows.Forms.Button();
            this.lbMaker = new System.Windows.Forms.Label();
            this.cbMaker = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCustomerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersSidebarPanel = new System.Windows.Forms.Panel();
            this.btnOrderFilter = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dataSet1 = new System.Data.DataSet();
            this.ssMain.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tcContent.SuspendLayout();
            this.tpCatalog.SuspendLayout();
            this.catalogGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.catalogSideBarPanel.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.ordersSidebarPanel.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.catalogGridPanel.Controls.Add(this.dgvCatalog);
            this.catalogGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogGridPanel.Location = new System.Drawing.Point(3, 3);
            this.catalogGridPanel.Name = "catalogGridPanel";
            this.catalogGridPanel.Size = new System.Drawing.Size(326, 228);
            this.catalogGridPanel.TabIndex = 9;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatalogNameColumn,
            this.CatalogDescriptionColumn,
            this.CatalogPriceColumn,
            this.CatalogInStockColumn});
            this.dgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalog.Location = new System.Drawing.Point(0, 0);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.Size = new System.Drawing.Size(326, 228);
            this.dgvCatalog.TabIndex = 1;
            // 
            // CatalogNameColumn
            // 
            this.CatalogNameColumn.HeaderText = "Name";
            this.CatalogNameColumn.Name = "CatalogNameColumn";
            this.CatalogNameColumn.ReadOnly = true;
            // 
            // CatalogDescriptionColumn
            // 
            this.CatalogDescriptionColumn.HeaderText = "Description";
            this.CatalogDescriptionColumn.Name = "CatalogDescriptionColumn";
            this.CatalogDescriptionColumn.ReadOnly = true;
            // 
            // CatalogPriceColumn
            // 
            this.CatalogPriceColumn.HeaderText = "Price";
            this.CatalogPriceColumn.Name = "CatalogPriceColumn";
            this.CatalogPriceColumn.ReadOnly = true;
            // 
            // CatalogInStockColumn
            // 
            this.CatalogInStockColumn.HeaderText = "InStock";
            this.CatalogInStockColumn.Name = "CatalogInStockColumn";
            this.CatalogInStockColumn.ReadOnly = true;
            // 
            // catalogSideBarPanel
            // 
            this.catalogSideBarPanel.AutoScroll = true;
            this.catalogSideBarPanel.Controls.Add(this.btnCatalogFilter);
            this.catalogSideBarPanel.Controls.Add(this.lbMaker);
            this.catalogSideBarPanel.Controls.Add(this.cbMaker);
            this.catalogSideBarPanel.Controls.Add(this.lbCategory);
            this.catalogSideBarPanel.Controls.Add(this.cbCategory);
            this.catalogSideBarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.catalogSideBarPanel.Location = new System.Drawing.Point(329, 3);
            this.catalogSideBarPanel.Name = "catalogSideBarPanel";
            this.catalogSideBarPanel.Size = new System.Drawing.Size(150, 228);
            this.catalogSideBarPanel.TabIndex = 8;
            // 
            // btnCatalogFilter
            // 
            this.btnCatalogFilter.Location = new System.Drawing.Point(6, 92);
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
            // cbMaker
            // 
            this.cbMaker.FormattingEnabled = true;
            this.cbMaker.Location = new System.Drawing.Point(6, 65);
            this.cbMaker.Name = "cbMaker";
            this.cbMaker.Size = new System.Drawing.Size(141, 21);
            this.cbMaker.TabIndex = 2;
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
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(6, 25);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(141, 21);
            this.cbCategory.TabIndex = 0;
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
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 228);
            this.panel1.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumColumn,
            this.OrderCustomerNameColumn,
            this.OrderCreatedColumn,
            this.OrderModifiedColumn});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(326, 228);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // OrderNumColumn
            // 
            this.OrderNumColumn.Frozen = true;
            this.OrderNumColumn.HeaderText = "#";
            this.OrderNumColumn.Name = "OrderNumColumn";
            this.OrderNumColumn.ReadOnly = true;
            // 
            // OrderCustomerNameColumn
            // 
            this.OrderCustomerNameColumn.HeaderText = "Customer";
            this.OrderCustomerNameColumn.Name = "OrderCustomerNameColumn";
            this.OrderCustomerNameColumn.ReadOnly = true;
            // 
            // OrderCreatedColumn
            // 
            this.OrderCreatedColumn.HeaderText = "Created";
            this.OrderCreatedColumn.Name = "OrderCreatedColumn";
            this.OrderCreatedColumn.ReadOnly = true;
            // 
            // OrderModifiedColumn
            // 
            this.OrderModifiedColumn.HeaderText = "Modified";
            this.OrderModifiedColumn.Name = "OrderModifiedColumn";
            this.OrderModifiedColumn.ReadOnly = true;
            // 
            // ordersSidebarPanel
            // 
            this.ordersSidebarPanel.Controls.Add(this.btnOrderFilter);
            this.ordersSidebarPanel.Controls.Add(this.cbCustomer);
            this.ordersSidebarPanel.Controls.Add(this.lbCustomer);
            this.ordersSidebarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersSidebarPanel.Location = new System.Drawing.Point(329, 3);
            this.ordersSidebarPanel.Name = "ordersSidebarPanel";
            this.ordersSidebarPanel.Size = new System.Drawing.Size(150, 228);
            this.ordersSidebarPanel.TabIndex = 2;
            // 
            // btnOrderFilter
            // 
            this.btnOrderFilter.Location = new System.Drawing.Point(6, 52);
            this.btnOrderFilter.Name = "btnOrderFilter";
            this.btnOrderFilter.Size = new System.Drawing.Size(75, 23);
            this.btnOrderFilter.TabIndex = 2;
            this.btnOrderFilter.Text = "Apply";
            this.btnOrderFilter.UseVisualStyleBackColor = true;
            this.btnOrderFilter.Click += new System.EventHandler(this.btnOrderFilter_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(6, 25);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 1;
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.catalogSideBarPanel.ResumeLayout(false);
            this.catalogSideBarPanel.PerformLayout();
            this.tpOrders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ordersSidebarPanel.ResumeLayout(false);
            this.ordersSidebarPanel.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TabControl tcContent;
        private System.Windows.Forms.TabPage tpCatalog;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Panel catalogGridPanel;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogInStockColumn;
        private System.Windows.Forms.Panel catalogSideBarPanel;
        private System.Windows.Forms.Button btnCatalogFilter;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.ComboBox cbMaker;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCustomerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderModifiedColumn;
        private System.Windows.Forms.Panel ordersSidebarPanel;
        private System.Windows.Forms.Button btnOrderFilter;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lbCustomer;
    }
}

