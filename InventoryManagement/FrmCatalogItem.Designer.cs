namespace InventoryManagement
{
    partial class FrmCatalogItem
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
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(29, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(140, 54);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(202, 20);
            this.tbxName.TabIndex = 3;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(140, 84);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(200, 57);
            this.tbxDescription.TabIndex = 5;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(29, 87);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "Description";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(29, 155);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(49, 13);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(140, 152);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(200, 21);
            this.cbxCategory.TabIndex = 7;
            // 
            // lbMaker
            // 
            this.lbMaker.AutoSize = true;
            this.lbMaker.Location = new System.Drawing.Point(29, 187);
            this.lbMaker.Name = "lbMaker";
            this.lbMaker.Size = new System.Drawing.Size(37, 13);
            this.lbMaker.TabIndex = 8;
            this.lbMaker.Text = "Maker";
            // 
            // cbxMaker
            // 
            this.cbxMaker.FormattingEnabled = true;
            this.cbxMaker.Location = new System.Drawing.Point(140, 184);
            this.cbxMaker.Name = "cbxMaker";
            this.cbxMaker.Size = new System.Drawing.Size(200, 21);
            this.cbxMaker.TabIndex = 9;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(29, 218);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "Price";
            // 
            // lbInStock
            // 
            this.lbInStock.AutoSize = true;
            this.lbInStock.Location = new System.Drawing.Point(29, 247);
            this.lbInStock.Name = "lbInStock";
            this.lbInStock.Size = new System.Drawing.Size(85, 13);
            this.lbInStock.TabIndex = 12;
            this.lbInStock.Text = "In Stock amount";
            // 
            // lbManufactureDate
            // 
            this.lbManufactureDate.AutoSize = true;
            this.lbManufactureDate.Location = new System.Drawing.Point(29, 283);
            this.lbManufactureDate.Name = "lbManufactureDate";
            this.lbManufactureDate.Size = new System.Drawing.Size(91, 13);
            this.lbManufactureDate.TabIndex = 14;
            this.lbManufactureDate.Text = "Manufacture date";
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Location = new System.Drawing.Point(140, 277);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpManufactureDate.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 357);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(140, 216);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(200, 20);
            this.nudPrice.TabIndex = 11;
            // 
            // nudInStock
            // 
            this.nudInStock.Location = new System.Drawing.Point(140, 245);
            this.nudInStock.Name = "nudInStock";
            this.nudInStock.Size = new System.Drawing.Size(200, 20);
            this.nudInStock.TabIndex = 13;
            // 
            // lbCatalogItemId
            // 
            this.lbCatalogItemId.AutoSize = true;
            this.lbCatalogItemId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCatalogItemId.Location = new System.Drawing.Point(29, 28);
            this.lbCatalogItemId.Name = "lbCatalogItemId";
            this.lbCatalogItemId.Size = new System.Drawing.Size(14, 13);
            this.lbCatalogItemId.TabIndex = 0;
            this.lbCatalogItemId.Text = "#";
            // 
            // tbxCatalogItemId
            // 
            this.tbxCatalogItemId.Location = new System.Drawing.Point(140, 21);
            this.tbxCatalogItemId.Name = "tbxCatalogItemId";
            this.tbxCatalogItemId.ReadOnly = true;
            this.tbxCatalogItemId.Size = new System.Drawing.Size(202, 20);
            this.tbxCatalogItemId.TabIndex = 1;
            // 
            // FrmCatalogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 415);
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
            this.MaximizeBox = false;
            this.Name = "FrmCatalogItem";
            this.Text = "Catalog Item";
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