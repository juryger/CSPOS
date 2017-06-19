namespace InventoryManagement
{
    partial class NewCatalogItemForm
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
            this.lbWarranty = new System.Windows.Forms.Label();
            this.nudWarranty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarranty)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWarranty
            // 
            this.lbWarranty.AutoSize = true;
            this.lbWarranty.Location = new System.Drawing.Point(29, 300);
            this.lbWarranty.Name = "lbWarranty";
            this.lbWarranty.Size = new System.Drawing.Size(50, 13);
            this.lbWarranty.TabIndex = 14;
            this.lbWarranty.Text = "Warranty";
            // 
            // nudWarranty
            // 
            this.nudWarranty.Location = new System.Drawing.Point(140, 293);
            this.nudWarranty.Name = "nudWarranty";
            this.nudWarranty.Size = new System.Drawing.Size(200, 20);
            this.nudWarranty.TabIndex = 15;
            // 
            // NewCatalogItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 394);
            this.Controls.Add(this.nudWarranty);
            this.Controls.Add(this.lbWarranty);
            this.Name = "NewCatalogItemForm";
            this.Text = "New catalog item";
            this.Controls.SetChildIndex(this.lbWarranty, 0);
            this.Controls.SetChildIndex(this.nudWarranty, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarranty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWarranty;
        private System.Windows.Forms.NumericUpDown nudWarranty;
    }
}