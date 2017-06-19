namespace InventoryManagement
{
    partial class CatalogItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogItemForm));
            this.lbName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbMaker = new System.Windows.Forms.Label();
            this.cbxMaker = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbInStock = new System.Windows.Forms.Label();
            this.lbManufactureDate = new System.Windows.Forms.Label();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudInStock = new System.Windows.Forms.NumericUpDown();
            this.lbCatalogItemId = new System.Windows.Forms.Label();
            this.tbxCatalogItemId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // tbxName
            // 
            resources.ApplyResources(this.tbxName, "tbxName");
            this.tbxName.Name = "tbxName";
            // 
            // tbxDescription
            // 
            resources.ApplyResources(this.tbxDescription, "tbxDescription");
            this.tbxDescription.Name = "tbxDescription";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // lbCategory
            // 
            resources.ApplyResources(this.lbCategory, "lbCategory");
            this.lbCategory.Name = "lbCategory";
            // 
            // cbxCategory
            // 
            resources.ApplyResources(this.cbxCategory, "cbxCategory");
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Name = "cbxCategory";
            // 
            // lbMaker
            // 
            resources.ApplyResources(this.lbMaker, "lbMaker");
            this.lbMaker.Name = "lbMaker";
            // 
            // cbxMaker
            // 
            resources.ApplyResources(this.cbxMaker, "cbxMaker");
            this.cbxMaker.FormattingEnabled = true;
            this.cbxMaker.Name = "cbxMaker";
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Name = "lbPrice";
            // 
            // lbInStock
            // 
            resources.ApplyResources(this.lbInStock, "lbInStock");
            this.lbInStock.Name = "lbInStock";
            // 
            // lbManufactureDate
            // 
            resources.ApplyResources(this.lbManufactureDate, "lbManufactureDate");
            this.lbManufactureDate.Name = "lbManufactureDate";
            // 
            // dtpManufactureDate
            // 
            resources.ApplyResources(this.dtpManufactureDate, "dtpManufactureDate");
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudPrice
            // 
            resources.ApplyResources(this.nudPrice, "nudPrice");
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            // 
            // nudInStock
            // 
            resources.ApplyResources(this.nudInStock, "nudInStock");
            this.nudInStock.Name = "nudInStock";
            // 
            // lbCatalogItemId
            // 
            resources.ApplyResources(this.lbCatalogItemId, "lbCatalogItemId");
            this.lbCatalogItemId.Name = "lbCatalogItemId";
            // 
            // tbxCatalogItemId
            // 
            resources.ApplyResources(this.tbxCatalogItemId, "tbxCatalogItemId");
            this.tbxCatalogItemId.Name = "tbxCatalogItemId";
            this.tbxCatalogItemId.ReadOnly = true;
            // 
            // CatalogItemForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxCatalogItemId);
            this.Controls.Add(this.lbCatalogItemId);
            this.Controls.Add(this.nudInStock);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpManufactureDate);
            this.Controls.Add(this.lbManufactureDate);
            this.Controls.Add(this.lbInStock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbxMaker);
            this.Controls.Add(this.lbMaker);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbName);
            this.Name = "CatalogItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.ComboBox cbxMaker;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbInStock;
        private System.Windows.Forms.Label lbManufactureDate;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudInStock;
        private System.Windows.Forms.Label lbCatalogItemId;
        private System.Windows.Forms.TextBox tbxCatalogItemId;
    }
}