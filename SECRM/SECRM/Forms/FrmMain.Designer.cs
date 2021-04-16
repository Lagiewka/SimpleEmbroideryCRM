namespace SECRM
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.tabEmbroidery = new System.Windows.Forms.TabPage();
            this.gridEmbroideries = new System.Windows.Forms.DataGridView();
            this.tabColor = new System.Windows.Forms.TabPage();
            this.gridColors = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.tabEmbroidery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmbroideries)).BeginInit();
            this.tabColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabEmbroidery);
            this.tabControl1.Controls.Add(this.tabColor);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabClient
            // 
            resources.ApplyResources(this.tabClient, "tabClient");
            this.tabClient.Controls.Add(this.gridClients);
            this.tabClient.Name = "tabClient";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // gridClients
            // 
            resources.ApplyResources(this.gridClients, "gridClients");
            this.gridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClients.Name = "gridClients";
            // 
            // tabEmbroidery
            // 
            resources.ApplyResources(this.tabEmbroidery, "tabEmbroidery");
            this.tabEmbroidery.Controls.Add(this.gridEmbroideries);
            this.tabEmbroidery.Name = "tabEmbroidery";
            this.tabEmbroidery.UseVisualStyleBackColor = true;
            // 
            // gridEmbroideries
            // 
            resources.ApplyResources(this.gridEmbroideries, "gridEmbroideries");
            this.gridEmbroideries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmbroideries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmbroideries.Name = "gridEmbroideries";
            // 
            // tabColor
            // 
            resources.ApplyResources(this.tabColor, "tabColor");
            this.tabColor.Controls.Add(this.gridColors);
            this.tabColor.Name = "tabColor";
            this.tabColor.UseVisualStyleBackColor = true;
            // 
            // gridColors
            // 
            resources.ApplyResources(this.gridColors, "gridColors");
            this.gridColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColors.Name = "gridColors";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            this.tabEmbroidery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmbroideries)).EndInit();
            this.tabColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabEmbroidery;
        private System.Windows.Forms.TabPage tabColor;
        private System.Windows.Forms.DataGridView gridClients;
        private System.Windows.Forms.DataGridView gridEmbroideries;
        private System.Windows.Forms.DataGridView gridColors;
    }
}

