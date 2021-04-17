namespace SECRM.Forms
{
    partial class frmColorAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorAdd));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblColorName = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lblColorCatalog = new System.Windows.Forms.Label();
            this.txtColorCatalog = new System.Windows.Forms.TextBox();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.ForeColor = System.Drawing.Color.Red;
            this.lblColorName.Location = new System.Drawing.Point(12, 15);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(63, 20);
            this.lblColorName.TabIndex = 1;
            this.lblColorName.Text = "Nome *:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(88, 12);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(237, 27);
            this.txtColorName.TabIndex = 2;
            this.txtColorName.TextChanged += new System.EventHandler(this.txtColorName_TextChanged);
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
            // txtColorCatalog
            // 
            this.txtColorCatalog.Location = new System.Drawing.Point(88, 45);
            this.txtColorCatalog.Name = "txtColorCatalog";
            this.txtColorCatalog.Size = new System.Drawing.Size(237, 27);
            this.txtColorCatalog.TabIndex = 2;
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
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(88, 78);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(237, 27);
            this.txtColorCode.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(231, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmColorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.lblColorCode);
            this.Controls.Add(this.txtColorCatalog);
            this.Controls.Add(this.lblColorCatalog);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.lblColorName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmColorAdd";
            this.Text = "Nova Cor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.Label lblColorCatalog;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtColorName;
        public System.Windows.Forms.TextBox txtColorCatalog;
        public System.Windows.Forms.TextBox txtColorCode;
    }
}