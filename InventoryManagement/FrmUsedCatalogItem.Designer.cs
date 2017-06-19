namespace InventoryManagement
{
    partial class FrmUsedCatalogItem
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
            this.lbCondition = new System.Windows.Forms.Label();
            this.cbxCondition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Location = new System.Drawing.Point(29, 316);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(51, 13);
            this.lbCondition.TabIndex = 16;
            this.lbCondition.Text = "Condition";
            // 
            // cbxCondition
            // 
            this.cbxCondition.FormattingEnabled = true;
            this.cbxCondition.Location = new System.Drawing.Point(138, 308);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(202, 21);
            this.cbxCondition.TabIndex = 17;
            // 
            // FrmUsedCatalogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 414);
            this.Controls.Add(this.cbxCondition);
            this.Controls.Add(this.lbCondition);
            this.Name = "FrmUsedCatalogItem";
            this.Text = "Used catalog item";
            this.Controls.SetChildIndex(this.lbCondition, 0);
            this.Controls.SetChildIndex(this.cbxCondition, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.ComboBox cbxCondition;
    }
}