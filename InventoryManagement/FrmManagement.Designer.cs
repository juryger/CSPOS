﻿namespace InventoryManagement
{
    partial class FrmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagement));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tcContent = new System.Windows.Forms.TabControl();
            this.tpCatalog = new System.Windows.Forms.TabPage();
            this.catalogGridPanel = new System.Windows.Forms.Panel();
            this.lbxCatalog = new System.Windows.Forms.ListBox();
            this.catalogSideBarPanel = new System.Windows.Forms.Panel();
            this.btnClearCatalogFilter = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnApplyCatalogFilter = new System.Windows.Forms.Button();
            this.lbMaker = new System.Windows.Forms.Label();
            this.cbxMaker = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.ordersSidebarPanel = new System.Windows.Forms.Panel();
            this.btnClearOrdersFilter = new System.Windows.Forms.Button();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.btnApplyOrderFilter = new System.Windows.Forms.Button();
            this.cbxOrderCustomer = new System.Windows.Forms.ComboBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
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
            this.tsStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 285);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(490, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(80, 17);
            this.tsStatus.Text = "Total count: #";
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
            this.tcContent.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcContent_Selecting);
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
            // lbxCatalog
            // 
            this.lbxCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxCatalog.FormattingEnabled = true;
            this.lbxCatalog.Location = new System.Drawing.Point(0, 0);
            this.lbxCatalog.Name = "lbxCatalog";
            this.lbxCatalog.Size = new System.Drawing.Size(326, 228);
            this.lbxCatalog.Sorted = true;
            this.lbxCatalog.TabIndex = 0;
            // 
            // catalogSideBarPanel
            // 
            this.catalogSideBarPanel.AutoScroll = true;
            this.catalogSideBarPanel.Controls.Add(this.btnClearCatalogFilter);
            this.catalogSideBarPanel.Controls.Add(this.lbType);
            this.catalogSideBarPanel.Controls.Add(this.cbxType);
            this.catalogSideBarPanel.Controls.Add(this.btnApplyCatalogFilter);
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
            // btnClearCatalogFilter
            // 
            this.btnClearCatalogFilter.Location = new System.Drawing.Point(58, 139);
            this.btnClearCatalogFilter.Name = "btnClearCatalogFilter";
            this.btnClearCatalogFilter.Size = new System.Drawing.Size(49, 23);
            this.btnClearCatalogFilter.TabIndex = 7;
            this.btnClearCatalogFilter.Text = "Clear";
            this.btnClearCatalogFilter.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(3, 91);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Type";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(6, 107);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(141, 21);
            this.cbxType.TabIndex = 5;
            // 
            // btnApplyCatalogFilter
            // 
            this.btnApplyCatalogFilter.Location = new System.Drawing.Point(6, 139);
            this.btnApplyCatalogFilter.Name = "btnApplyCatalogFilter";
            this.btnApplyCatalogFilter.Size = new System.Drawing.Size(46, 23);
            this.btnApplyCatalogFilter.TabIndex = 4;
            this.btnApplyCatalogFilter.Text = "Apply";
            this.btnApplyCatalogFilter.UseVisualStyleBackColor = true;
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
            this.cbxMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lbxOrders
            // 
            this.lbxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.Location = new System.Drawing.Point(0, 0);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(326, 228);
            this.lbxOrders.TabIndex = 0;
            // 
            // ordersSidebarPanel
            // 
            this.ordersSidebarPanel.Controls.Add(this.btnClearOrdersFilter);
            this.ordersSidebarPanel.Controls.Add(this.cbxOrderStatus);
            this.ordersSidebarPanel.Controls.Add(this.lbOrderStatus);
            this.ordersSidebarPanel.Controls.Add(this.btnApplyOrderFilter);
            this.ordersSidebarPanel.Controls.Add(this.cbxOrderCustomer);
            this.ordersSidebarPanel.Controls.Add(this.lbCustomer);
            this.ordersSidebarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersSidebarPanel.Location = new System.Drawing.Point(329, 3);
            this.ordersSidebarPanel.Name = "ordersSidebarPanel";
            this.ordersSidebarPanel.Size = new System.Drawing.Size(150, 228);
            this.ordersSidebarPanel.TabIndex = 2;
            // 
            // btnClearOrdersFilter
            // 
            this.btnClearOrdersFilter.Location = new System.Drawing.Point(60, 96);
            this.btnClearOrdersFilter.Name = "btnClearOrdersFilter";
            this.btnClearOrdersFilter.Size = new System.Drawing.Size(48, 23);
            this.btnClearOrdersFilter.TabIndex = 5;
            this.btnClearOrdersFilter.Text = "Clear";
            this.btnClearOrdersFilter.UseVisualStyleBackColor = true;
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // btnApplyOrderFilter
            // 
            this.btnApplyOrderFilter.Location = new System.Drawing.Point(6, 96);
            this.btnApplyOrderFilter.Name = "btnApplyOrderFilter";
            this.btnApplyOrderFilter.Size = new System.Drawing.Size(48, 23);
            this.btnApplyOrderFilter.TabIndex = 2;
            this.btnApplyOrderFilter.Text = "Apply";
            this.btnApplyOrderFilter.UseVisualStyleBackColor = true;
            // 
            // cbxOrderCustomer
            // 
            this.cbxOrderCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.tsbRefresh,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete});
            this.tsMain.Location = new System.Drawing.Point(3, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(234, 25);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "tsMain";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
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
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
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
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 307);
            this.Controls.Add(this.tsContainer);
            this.Controls.Add(this.ssMain);
            this.Name = "FrmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TabControl tcContent;
        private System.Windows.Forms.TabPage tpCatalog;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Panel catalogGridPanel;
        private System.Windows.Forms.Panel catalogSideBarPanel;
        private System.Windows.Forms.Button btnApplyCatalogFilter;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.ComboBox cbxMaker;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ordersSidebarPanel;
        private System.Windows.Forms.Button btnApplyOrderFilter;
        private System.Windows.Forms.ComboBox cbxOrderCustomer;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ListBox lbxCatalog;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Button btnClearCatalogFilter;
        private System.Windows.Forms.Button btnClearOrdersFilter;
    }
}

