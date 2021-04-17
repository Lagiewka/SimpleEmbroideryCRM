namespace SECRM.Forms
{
    partial class frmClientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientDetail));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientMachine = new System.Windows.Forms.Label();
            this.lblClientMacineVar = new System.Windows.Forms.Label();
            this.lblClientEmailVar = new System.Windows.Forms.Label();
            this.lblClientPhoneVar = new System.Windows.Forms.Label();
            this.lblClientNameVar = new System.Windows.Forms.Label();
            this.lblClientEmbCount = new System.Windows.Forms.Label();
            this.lblClientEmbCountVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(131, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClientName.Location = new System.Drawing.Point(12, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(53, 20);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Nome:";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(12, 48);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(44, 20);
            this.lblClientPhone.TabIndex = 1;
            this.lblClientPhone.Text = "Fone:";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(12, 81);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(49, 20);
            this.lblClientEmail.TabIndex = 1;
            this.lblClientEmail.Text = "Email:";
            // 
            // lblClientMachine
            // 
            this.lblClientMachine.AutoSize = true;
            this.lblClientMachine.Location = new System.Drawing.Point(12, 114);
            this.lblClientMachine.Name = "lblClientMachine";
            this.lblClientMachine.Size = new System.Drawing.Size(70, 20);
            this.lblClientMachine.TabIndex = 1;
            this.lblClientMachine.Text = "Máquina:";
            // 
            // lblClientMacineVar
            // 
            this.lblClientMacineVar.AutoSize = true;
            this.lblClientMacineVar.Location = new System.Drawing.Point(128, 114);
            this.lblClientMacineVar.Name = "lblClientMacineVar";
            this.lblClientMacineVar.Size = new System.Drawing.Size(104, 20);
            this.lblClientMacineVar.TabIndex = 2;
            this.lblClientMacineVar.Text = "[Place Holder]";
            // 
            // lblClientEmailVar
            // 
            this.lblClientEmailVar.AutoSize = true;
            this.lblClientEmailVar.Location = new System.Drawing.Point(128, 81);
            this.lblClientEmailVar.Name = "lblClientEmailVar";
            this.lblClientEmailVar.Size = new System.Drawing.Size(104, 20);
            this.lblClientEmailVar.TabIndex = 2;
            this.lblClientEmailVar.Text = "[Place Holder]";
            // 
            // lblClientPhoneVar
            // 
            this.lblClientPhoneVar.AutoSize = true;
            this.lblClientPhoneVar.Location = new System.Drawing.Point(128, 48);
            this.lblClientPhoneVar.Name = "lblClientPhoneVar";
            this.lblClientPhoneVar.Size = new System.Drawing.Size(104, 20);
            this.lblClientPhoneVar.TabIndex = 2;
            this.lblClientPhoneVar.Text = "[Place Holder]";
            // 
            // lblClientNameVar
            // 
            this.lblClientNameVar.AutoSize = true;
            this.lblClientNameVar.Location = new System.Drawing.Point(128, 15);
            this.lblClientNameVar.Name = "lblClientNameVar";
            this.lblClientNameVar.Size = new System.Drawing.Size(104, 20);
            this.lblClientNameVar.TabIndex = 2;
            this.lblClientNameVar.Text = "[Place Holder]";
            // 
            // lblClientEmbCount
            // 
            this.lblClientEmbCount.AutoSize = true;
            this.lblClientEmbCount.Location = new System.Drawing.Point(12, 147);
            this.lblClientEmbCount.Name = "lblClientEmbCount";
            this.lblClientEmbCount.Size = new System.Drawing.Size(110, 20);
            this.lblClientEmbCount.TabIndex = 1;
            this.lblClientEmbCount.Text = "Nº de Matrizes:";
            // 
            // lblClientEmbCountVar
            // 
            this.lblClientEmbCountVar.AutoSize = true;
            this.lblClientEmbCountVar.Location = new System.Drawing.Point(128, 147);
            this.lblClientEmbCountVar.Name = "lblClientEmbCountVar";
            this.lblClientEmbCountVar.Size = new System.Drawing.Size(104, 20);
            this.lblClientEmbCountVar.TabIndex = 2;
            this.lblClientEmbCountVar.Text = "[Place Holder]";
            // 
            // frmClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 243);
            this.Controls.Add(this.lblClientEmbCountVar);
            this.Controls.Add(this.lblClientEmbCount);
            this.Controls.Add(this.lblClientNameVar);
            this.Controls.Add(this.lblClientPhoneVar);
            this.Controls.Add(this.lblClientEmailVar);
            this.Controls.Add(this.lblClientMacineVar);
            this.Controls.Add(this.lblClientMachine);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientDetail";
            this.Text = "Detalhes do Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientMachine;
        private System.Windows.Forms.Label lblClientEmbCount;
        public System.Windows.Forms.Label lblClientMacineVar;
        public System.Windows.Forms.Label lblClientEmailVar;
        public System.Windows.Forms.Label lblClientPhoneVar;
        public System.Windows.Forms.Label lblClientNameVar;
        public System.Windows.Forms.Label lblClientEmbCountVar;
    }
}