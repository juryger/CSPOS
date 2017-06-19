namespace InventoryManagement
{
    partial class FrmSparePartTypeSelection
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
            this.rbtnNewItem = new System.Windows.Forms.RadioButton();
            this.rbtnUsedItem = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnNewItem
            // 
            this.rbtnNewItem.AutoSize = true;
            this.rbtnNewItem.Checked = true;
            this.rbtnNewItem.Location = new System.Drawing.Point(42, 47);
            this.rbtnNewItem.Name = "rbtnNewItem";
            this.rbtnNewItem.Size = new System.Drawing.Size(126, 17);
            this.rbtnNewItem.TabIndex = 0;
            this.rbtnNewItem.TabStop = true;
            this.rbtnNewItem.Text = "Brand new spare part";
            this.rbtnNewItem.UseVisualStyleBackColor = true;
            // 
            // rbtnUsedItem
            // 
            this.rbtnUsedItem.AutoSize = true;
            this.rbtnUsedItem.Location = new System.Drawing.Point(42, 70);
            this.rbtnUsedItem.Name = "rbtnUsedItem";
            this.rbtnUsedItem.Size = new System.Drawing.Size(100, 17);
            this.rbtnUsedItem.TabIndex = 1;
            this.rbtnUsedItem.Text = "Used spare part";
            this.rbtnUsedItem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(159, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(67, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "Select";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Which spare part type you would like to add?";
            // 
            // FrmSparePartTypeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtnUsedItem);
            this.Controls.Add(this.rbtnNewItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSparePartTypeSelection";
            this.Text = "New spare part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnNewItem;
        private System.Windows.Forms.RadioButton rbtnUsedItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}