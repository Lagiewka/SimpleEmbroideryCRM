namespace SECRM.Forms
{
    partial class frmColorDetail
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblColorName = new System.Windows.Forms.Label();
            this.lblColorCatalog = new System.Windows.Forms.Label();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.lblColorCodeVar = new System.Windows.Forms.Label();
            this.lblColorCatalogVar = new System.Windows.Forms.Label();
            this.lblColorNameVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(131, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorName.Location = new System.Drawing.Point(12, 15);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(53, 20);
            this.lblColorName.TabIndex = 1;
            this.lblColorName.Text = "Nome:";
            // 
            // lblColorCatalog
            // 
            this.lblColorCatalog.AutoSize = true;
            this.lblColorCatalog.Location = new System.Drawing.Point(12, 48);
            this.lblColorCatalog.Name = "lblColorCatalog";
            this.lblColorCatalog.Size = new System.Drawing.Size(55, 20);
            this.lblColorCatalog.TabIndex = 1;
            this.lblColorCatalog.Text = "Tabela:";
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Location = new System.Drawing.Point(12, 81);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(66, 20);
            this.lblColorCode.TabIndex = 1;
            this.lblColorCode.Text = "Número:";
            // 
            // lblColorCodeVar
            // 
            this.lblColorCodeVar.AutoSize = true;
            this.lblColorCodeVar.Location = new System.Drawing.Point(128, 81);
            this.lblColorCodeVar.Name = "lblColorCodeVar";
            this.lblColorCodeVar.Size = new System.Drawing.Size(104, 20);
            this.lblColorCodeVar.TabIndex = 2;
            this.lblColorCodeVar.Text = "[Place Holder]";
            // 
            // lblColorCatalogVar
            // 
            this.lblColorCatalogVar.AutoSize = true;
            this.lblColorCatalogVar.Location = new System.Drawing.Point(128, 48);
            this.lblColorCatalogVar.Name = "lblColorCatalogVar";
            this.lblColorCatalogVar.Size = new System.Drawing.Size(104, 20);
            this.lblColorCatalogVar.TabIndex = 2;
            this.lblColorCatalogVar.Text = "[Place Holder]";
            // 
            // lblColorNameVar
            // 
            this.lblColorNameVar.AutoSize = true;
            this.lblColorNameVar.Location = new System.Drawing.Point(128, 15);
            this.lblColorNameVar.Name = "lblColorNameVar";
            this.lblColorNameVar.Size = new System.Drawing.Size(104, 20);
            this.lblColorNameVar.TabIndex = 2;
            this.lblColorNameVar.Text = "[Place Holder]";
            // 
            // frmColorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 153);
            this.Controls.Add(this.lblColorNameVar);
            this.Controls.Add(this.lblColorCatalogVar);
            this.Controls.Add(this.lblColorCodeVar);
            this.Controls.Add(this.lblColorCode);
            this.Controls.Add(this.lblColorCatalog);
            this.Controls.Add(this.lblColorName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmColorDetail";
            this.Text = "Detalhes do Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.Label lblColorCatalog;
        private System.Windows.Forms.Label lblColorCode;
        public System.Windows.Forms.Label lblColorCodeVar;
        public System.Windows.Forms.Label lblColorCatalogVar;
        public System.Windows.Forms.Label lblColorNameVar;
    }
}