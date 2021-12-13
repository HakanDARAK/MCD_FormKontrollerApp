namespace MCD_FormKontrollerApp
{
    partial class SavedCustomer
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
            this.lstSavedInfırmation = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSavedInfırmation
            // 
            this.lstSavedInfırmation.FormattingEnabled = true;
            this.lstSavedInfırmation.Location = new System.Drawing.Point(12, 12);
            this.lstSavedInfırmation.Name = "lstSavedInfırmation";
            this.lstSavedInfırmation.Size = new System.Drawing.Size(268, 121);
            this.lstSavedInfırmation.TabIndex = 0;
          
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SavedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 189);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstSavedInfırmation);
            this.Name = "SavedCustomer";
            this.Text = "Saved Customer Information";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ListBox lstSavedInfırmation;
    }
}