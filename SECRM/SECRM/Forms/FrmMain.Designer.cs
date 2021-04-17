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
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnClientInfo = new System.Windows.Forms.Button();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.tabEmbroidery = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmbAdd = new System.Windows.Forms.Button();
            this.btnEmbEdit = new System.Windows.Forms.Button();
            this.btnEmbDelete = new System.Windows.Forms.Button();
            this.btnEmbSearch = new System.Windows.Forms.Button();
            this.btnEmbInfo = new System.Windows.Forms.Button();
            this.txtEmbSearch = new System.Windows.Forms.TextBox();
            this.gridEmbroideries = new System.Windows.Forms.DataGridView();
            this.tabColor = new System.Windows.Forms.TabPage();
            this.txtColorSearch = new System.Windows.Forms.TextBox();
            this.btnColorInfo = new System.Windows.Forms.Button();
            this.btnColorSearch = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.btnColorAdd = new System.Windows.Forms.Button();
            this.gridColors = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.tabEmbroidery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabClient.Controls.Add(this.txtClientSearch);
            this.tabClient.Controls.Add(this.btnClientInfo);
            this.tabClient.Controls.Add(this.btnClientSearch);
            this.tabClient.Controls.Add(this.btnClientDelete);
            this.tabClient.Controls.Add(this.btnClientAdd);
            this.tabClient.Controls.Add(this.gridClients);
            this.tabClient.Name = "tabClient";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // txtClientSearch
            // 
            resources.ApplyResources(this.txtClientSearch, "txtClientSearch");
            this.txtClientSearch.Name = "txtClientSearch";
            // 
            // btnClientInfo
            // 
            resources.ApplyResources(this.btnClientInfo, "btnClientInfo");
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.UseVisualStyleBackColor = true;
            this.btnClientInfo.Click += new System.EventHandler(this.btnClientInfo_Click);
            // 
            // btnClientSearch
            // 
            resources.ApplyResources(this.btnClientSearch, "btnClientSearch");
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // btnClientDelete
            // 
            resources.ApplyResources(this.btnClientDelete, "btnClientDelete");
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.UseVisualStyleBackColor = true;
            this.btnClientDelete.Click += new System.EventHandler(this.btnClientDelete_Click);
            // 
            // btnClientAdd
            // 
            resources.ApplyResources(this.btnClientAdd, "btnClientAdd");
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // gridClients
            // 
            resources.ApplyResources(this.gridClients, "gridClients");
            this.gridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClients.Name = "gridClients";
            this.gridClients.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClients_CellEndEdit);
            // 
            // tabEmbroidery
            // 
            resources.ApplyResources(this.tabEmbroidery, "tabEmbroidery");
            this.tabEmbroidery.Controls.Add(this.pictureBox1);
            this.tabEmbroidery.Controls.Add(this.btnEmbAdd);
            this.tabEmbroidery.Controls.Add(this.btnEmbEdit);
            this.tabEmbroidery.Controls.Add(this.btnEmbDelete);
            this.tabEmbroidery.Controls.Add(this.btnEmbSearch);
            this.tabEmbroidery.Controls.Add(this.btnEmbInfo);
            this.tabEmbroidery.Controls.Add(this.txtEmbSearch);
            this.tabEmbroidery.Controls.Add(this.gridEmbroideries);
            this.tabEmbroidery.Name = "tabEmbroidery";
            this.tabEmbroidery.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnEmbAdd
            // 
            resources.ApplyResources(this.btnEmbAdd, "btnEmbAdd");
            this.btnEmbAdd.Name = "btnEmbAdd";
            this.btnEmbAdd.UseVisualStyleBackColor = true;
            // 
            // btnEmbEdit
            // 
            resources.ApplyResources(this.btnEmbEdit, "btnEmbEdit");
            this.btnEmbEdit.Name = "btnEmbEdit";
            this.btnEmbEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmbDelete
            // 
            resources.ApplyResources(this.btnEmbDelete, "btnEmbDelete");
            this.btnEmbDelete.Name = "btnEmbDelete";
            this.btnEmbDelete.UseVisualStyleBackColor = true;
            this.btnEmbDelete.Click += new System.EventHandler(this.btnEmbDelete_Click);
            // 
            // btnEmbSearch
            // 
            resources.ApplyResources(this.btnEmbSearch, "btnEmbSearch");
            this.btnEmbSearch.Name = "btnEmbSearch";
            this.btnEmbSearch.UseVisualStyleBackColor = true;
            this.btnEmbSearch.Click += new System.EventHandler(this.btnEmbSearch_Click);
            // 
            // btnEmbInfo
            // 
            resources.ApplyResources(this.btnEmbInfo, "btnEmbInfo");
            this.btnEmbInfo.Name = "btnEmbInfo";
            this.btnEmbInfo.UseVisualStyleBackColor = true;
            // 
            // txtEmbSearch
            // 
            resources.ApplyResources(this.txtEmbSearch, "txtEmbSearch");
            this.txtEmbSearch.Name = "txtEmbSearch";
            // 
            // gridEmbroideries
            // 
            resources.ApplyResources(this.gridEmbroideries, "gridEmbroideries");
            this.gridEmbroideries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmbroideries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmbroideries.Name = "gridEmbroideries";
            this.gridEmbroideries.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmbroideries_CellEndEdit);
            // 
            // tabColor
            // 
            resources.ApplyResources(this.tabColor, "tabColor");
            this.tabColor.Controls.Add(this.txtColorSearch);
            this.tabColor.Controls.Add(this.btnColorInfo);
            this.tabColor.Controls.Add(this.btnColorSearch);
            this.tabColor.Controls.Add(this.btnColorDelete);
            this.tabColor.Controls.Add(this.btnColorAdd);
            this.tabColor.Controls.Add(this.gridColors);
            this.tabColor.Name = "tabColor";
            this.tabColor.UseVisualStyleBackColor = true;
            // 
            // txtColorSearch
            // 
            resources.ApplyResources(this.txtColorSearch, "txtColorSearch");
            this.txtColorSearch.Name = "txtColorSearch";
            // 
            // btnColorInfo
            // 
            resources.ApplyResources(this.btnColorInfo, "btnColorInfo");
            this.btnColorInfo.Name = "btnColorInfo";
            this.btnColorInfo.UseVisualStyleBackColor = true;
            this.btnColorInfo.Click += new System.EventHandler(this.btnColorInfo_Click);
            // 
            // btnColorSearch
            // 
            resources.ApplyResources(this.btnColorSearch, "btnColorSearch");
            this.btnColorSearch.Name = "btnColorSearch";
            this.btnColorSearch.UseVisualStyleBackColor = true;
            this.btnColorSearch.Click += new System.EventHandler(this.btnColorSearch_Click);
            // 
            // btnColorDelete
            // 
            resources.ApplyResources(this.btnColorDelete, "btnColorDelete");
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // btnColorAdd
            // 
            resources.ApplyResources(this.btnColorAdd, "btnColorAdd");
            this.btnColorAdd.Name = "btnColorAdd";
            this.btnColorAdd.UseVisualStyleBackColor = true;
            this.btnColorAdd.Click += new System.EventHandler(this.btnColorAdd_Click);
            // 
            // gridColors
            // 
            resources.ApplyResources(this.gridColors, "gridColors");
            this.gridColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColors.Name = "gridColors";
            this.gridColors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColors_CellEndEdit);
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
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            this.tabEmbroidery.ResumeLayout(false);
            this.tabEmbroidery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmbroideries)).EndInit();
            this.tabColor.ResumeLayout(false);
            this.tabColor.PerformLayout();
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
        private System.Windows.Forms.Button btnClientInfo;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.Button btnClientDelete;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button btnEmbAdd;
        private System.Windows.Forms.Button btnEmbEdit;
        private System.Windows.Forms.Button btnEmbDelete;
        private System.Windows.Forms.Button btnEmbSearch;
        private System.Windows.Forms.Button btnEmbInfo;
        private System.Windows.Forms.TextBox txtEmbSearch;
        private System.Windows.Forms.TextBox txtColorSearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnColorSearch;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.Button btnColorAdd;
        private System.Windows.Forms.Button btnColorInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

