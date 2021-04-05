using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECRM
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            sqliteConnection.Open();
            SqliteDataReader reader = All_From_Client.ExecuteReader();
            sqliteConnection.Close();
        }
    }
}
