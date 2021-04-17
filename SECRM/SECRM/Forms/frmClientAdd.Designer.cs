namespace SECRM.Forms
{
    partial class frmClientAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientAdd));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientMachine = new System.Windows.Forms.Label();
            this.txtClientMachine = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.ForeColor = System.Drawing.Color.Red;
            this.lblClientName.Location = new System.Drawing.Point(12, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(63, 20);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Nome *:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(88, 12);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(237, 27);
            this.txtClientName.TabIndex = 2;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
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
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(88, 45);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(237, 27);
            this.txtClientPhone.TabIndex = 2;
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
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(88, 78);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(237, 27);
            this.txtClientEmail.TabIndex = 2;
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
            // txtClientMachine
            // 
            this.txtClientMachine.Location = new System.Drawing.Point(88, 111);
            this.txtClientMachine.Name = "txtClientMachine";
            this.txtClientMachine.Size = new System.Drawing.Size(237, 27);
            this.txtClientMachine.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(231, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtClientMachine);
            this.Controls.Add(this.lblClientMachine);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.txtClientPhone);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientAdd";
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientMachine;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtClientName;
        public System.Windows.Forms.TextBox txtClientPhone;
        public System.Windows.Forms.TextBox txtClientEmail;
        public System.Windows.Forms.TextBox txtClientMachine;
    }
}