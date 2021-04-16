using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SECRM.Models;

namespace SECRM
{
    public partial class FrmMain : Form
    {
        private SECRMDBContext dbContext = new SECRMDBContext();
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            gridClients.DataSource = dbContext.Clients.ToList();
            gridEmbroideries.DataSource = dbContext.Embroideries.ToList();
            gridColors.DataSource = dbContext.Colors.ToList();

            gridClients.Columns[0].Visible = false; //Id
            gridClients.Columns[5].Visible = false; //Embroideries

            gridColors.Columns[0].Visible = false; //Id
            gridColors.Columns[4].Visible = false; //EmbroideryColors

            gridEmbroideries.Columns[0].Visible = false; //Id
            gridEmbroideries.Columns[2].Visible = false; //Image
            gridEmbroideries.Columns[12].Visible = false; //ClientId
            gridEmbroideries.Columns[14].Visible = false; //EmbroideryColors           
        }
    }
}
