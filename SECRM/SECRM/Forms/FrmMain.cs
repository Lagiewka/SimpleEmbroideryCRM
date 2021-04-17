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
using SECRM.Forms;

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
            UpdateGridClient();
            gridEmbroideries.DataSource = dbContext.Embroideries.ToList();
            gridColors.DataSource = dbContext.Colors.ToList();


            gridColors.Columns[0].Visible = false; //Id
            gridColors.Columns[4].Visible = false; //EmbroideryColors

            gridEmbroideries.Columns[0].Visible = false; //Id
            gridEmbroideries.Columns[2].Visible = false; //Image
            gridEmbroideries.Columns[12].Visible = false; //ClientId
            gridEmbroideries.Columns[14].Visible = false; //EmbroideryColors           
        }

        private void UpdateGridClient(string filter = "")
        {
            if (string.IsNullOrEmpty(filter))
            {
                gridClients.DataSource = dbContext.Clients.ToList();
            }
            else
            {
                var searchResults = dbContext.Clients.ToList().FindAll(c => c.Name.Contains(filter) ||
                                                                        c.Machine.Contains(filter) ||
                                                                        c.Email.Contains(filter));

                gridClients.DataSource = searchResults;
            }
            gridClients.Columns[0].Visible = false; //Id
            gridClients.Columns[5].Visible = false; //Embroideries
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            frmClientAdd frmAddClient = new frmClientAdd();
            if (frmAddClient.ShowDialog(this) == DialogResult.OK)
            {
                Client client = new Client
                {
                    Name = frmAddClient.txtClientName.Text,
                    Phone = frmAddClient.txtClientPhone.Text,
                    Email = frmAddClient.txtClientEmail.Text,
                    Machine = frmAddClient.txtClientMachine.Text
                };
                dbContext.Add(client);
                dbContext.SaveChanges();
                UpdateGridClient();
            }
            frmAddClient.Dispose();
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientSearch.Text))
                UpdateGridClient(txtClientSearch.Text);
            else
                UpdateGridClient();
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            var records = gridClients.SelectedRows;
            if (records.Count > 0)
            {
                var dialogResult = MessageBox.Show($"Tem certeza de que quer excluir essas {records.Count} entrada(s)?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Client> markedForRemoval = new List<Client>();
                    foreach (DataGridViewRow r in records)
                    {
                        markedForRemoval.Add(dbContext.Find<Client>(r.Cells[0].Value));
                    }

                    dbContext.RemoveRange(markedForRemoval);
                    dbContext.SaveChanges();
                    UpdateGridClient();
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos uma linha para deletar");
            }
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            gridClients.
        }
    }
}
