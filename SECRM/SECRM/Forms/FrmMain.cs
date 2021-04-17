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

        enum DeletionOrigin
        {
            Color,
            Embroidery
        }

        public FrmMain()
        {
            InitializeComponent();            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateGridClient();
            UpdateGridColor();
            UpdateGridEmbroidery();
        }

        #region Client        
        private void UpdateGridClient(string filter = "")
        {
            if (string.IsNullOrEmpty(filter))
            {
                gridClients.DataSource = dbContext.Clients.ToList();
                txtClientSearch.Text = string.Empty;
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
                        Client c = dbContext.Find<Client>(r.Cells[0].Value);
                        if (c.Embroideries.Count > 0)
                        {
                            MessageBox.Show($"O cliente {c.Name} ainda tem bordados registrados. \nExclua os bordados desse cliente antes de excluí-lo.", "Deleção não efetuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            markedForRemoval.Add(c);
                    }

                    if (markedForRemoval.Count > 0)
                    {
                        dbContext.RemoveRange(markedForRemoval);
                        dbContext.SaveChanges();
                        UpdateGridClient();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos uma linha para deletar");
            }
        }

        private void gridClients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dbContext.Update(dbContext.Clients.Find(Convert.ToInt32(gridClients.Rows[e.RowIndex].Cells[0].Value)));
            dbContext.SaveChanges();
        }

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            switch (gridClients.SelectedRows.Count)
            {
                case 1:
                    DataGridViewRow row = gridClients.SelectedRows[0];
                    Client cli = dbContext.Clients.Find(row.Cells[0].Value);
                    frmClientDetail frmDetailClient = new frmClientDetail();
                    frmDetailClient.lblClientNameVar.Text = cli.Name;
                    frmDetailClient.lblClientPhoneVar.Text = cli.Phone;
                    frmDetailClient.lblClientEmailVar.Text = cli.Email;
                    frmDetailClient.lblClientMacineVar.Text = cli.Machine;
                    frmDetailClient.lblClientEmbCountVar.Text = cli.Embroideries.Count.ToString();
                    frmDetailClient.ShowDialog();
                    break;
                case 0:
                    MessageBox.Show("Selecione um registro para ver os detalhes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    MessageBox.Show("Só é possível ver os detalhes de um registro por vez", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
        #endregion

        #region Color
        private void UpdateGridColor(string filter = "")
        {
            if (string.IsNullOrEmpty(filter))
            {                
                gridColors.DataSource = dbContext.Colors.ToList();
                txtColorSearch.Text = string.Empty;
            }
            else
            {
                var searchResults = dbContext.Colors.ToList().FindAll(c => c.Name.Contains(filter) ||
                                                                        c.Catalog.Contains(filter) ||
                                                                        c.Code.Contains(filter));

                gridClients.DataSource = searchResults;
            }
            gridColors.Columns[0].Visible = false; //Id
            gridColors.Columns[4].Visible = false; //EmbroideryColors
        }

        private void btnColorSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColorSearch.Text))
                UpdateGridClient(txtColorSearch.Text);
            else
                UpdateGridClient();
        }

        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            frmColorAdd frmAddColor = new frmColorAdd();
            if (frmAddColor.ShowDialog(this) == DialogResult.OK)
            {
                Models.Color color = new Models.Color
                {
                    Name = frmAddColor.txtColorName.Text,
                    Catalog = frmAddColor.txtColorCatalog.Text,
                    Code = frmAddColor.txtColorCode.Text
                };
                dbContext.Add(color);
                dbContext.SaveChanges();
                UpdateGridColor();
            }
            frmAddColor.Dispose();
        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            var records = gridColors.SelectedRows;
            if (records.Count > 0)
            {
                var dialogResult = MessageBox.Show($"Tem certeza de que quer excluir essas {records.Count} entrada(s)?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Models.Color> markedForRemoval = new List<Models.Color>();
                    foreach (DataGridViewRow r in records)
                    {
                        int clrId = Convert.ToInt32(r.Cells[0].Value);
                        markedForRemoval.Add(dbContext.Find<Models.Color>(clrId));
                        RemoveAssociatedEmbroideryColors(clrId, DeletionOrigin.Color);
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

        private void gridColors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dbContext.Update(dbContext.Colors.Find(Convert.ToInt32(gridColors.Rows[e.RowIndex].Cells[0].Value)));
            dbContext.SaveChanges();
        }

        private void btnColorInfo_Click(object sender, EventArgs e)
        {
            switch (gridClients.SelectedRows.Count)
            {
                case 1:
                    DataGridViewRow row = gridColors.SelectedRows[0];
                    Models.Color color = dbContext.Colors.Find(row.Cells[0].Value);
                    frmColorDetail frmDetailColor = new frmColorDetail();
                    frmDetailColor.lblColorNameVar.Text = color.Name;
                    frmDetailColor.lblColorCatalogVar.Text = color.Catalog;
                    frmDetailColor.lblColorCodeVar.Text = color.Code;
                    frmDetailColor.ShowDialog();
                    break;
                case 0:
                    MessageBox.Show("Selecione um registro para ver os detalhes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    MessageBox.Show("Só é possível ver os detalhes de um registro por vez", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        #endregion

        #region Embroidery
        private void UpdateGridEmbroidery(string filter = "")
        {
            if (string.IsNullOrEmpty(filter))
            {
                gridEmbroideries.DataSource = dbContext.Embroideries.ToList();
                txtEmbSearch.Text = string.Empty;
            }
            else
            {
                var searchResults = dbContext.Embroideries.ToList().FindAll(e => e.Name.Contains(filter) ||
                                                                        e.Observations.Contains(filter) ||
                                                                        e.Client.Name.Contains(filter));

                gridClients.DataSource = searchResults;
            }
            gridEmbroideries.Columns[0].Visible = false; //Id
            gridEmbroideries.Columns[2].Visible = false; //Image
            gridEmbroideries.Columns[12].Visible = false; //ClientId
            gridEmbroideries.Columns[14].Visible = false; //EmbroideryColors
        }

        private void btnEmbSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmbSearch.Text))
                UpdateGridEmbroidery(txtEmbSearch.Text);
            else
                UpdateGridEmbroidery();
        }

        private void btnEmbDelete_Click(object sender, EventArgs e)
        {
            var records = gridEmbroideries.SelectedRows;
            if (records.Count > 0)
            {
                var dialogResult = MessageBox.Show($"Tem certeza de que quer excluir essas {records.Count} entrada(s)?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Embroidery> markedForRemoval = new List<Embroidery>();
                    foreach (DataGridViewRow r in records)
                    {
                        int embId = Convert.ToInt32(r.Cells[0].Value);
                        markedForRemoval.Add(dbContext.Find<Embroidery>(embId));
                        RemoveAssociatedEmbroideryColors(embId,DeletionOrigin.Embroidery);
                    }

                    dbContext.RemoveRange(markedForRemoval);
                    dbContext.SaveChanges();
                    UpdateGridEmbroidery();
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos uma linha para deletar");
            }
        }

        private void gridEmbroideries_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dbContext.Update(dbContext.Embroideries.Find(Convert.ToInt32(gridEmbroideries.Rows[e.RowIndex].Cells[0].Value)));
            dbContext.SaveChanges();
        }

        #endregion

        private void RemoveAssociatedEmbroideryColors(int id, DeletionOrigin origin)
        {
            switch (origin)
            {
                case DeletionOrigin.Color:
                    dbContext.EmbroideryColors.RemoveRange
                    (
                        dbContext.EmbroideryColors.ToList().FindAll(ec => ec.ColorId == id)
                    );
                    break;
                case DeletionOrigin.Embroidery:
                    dbContext.EmbroideryColors.RemoveRange
                    (
                        dbContext.EmbroideryColors.ToList().FindAll(ec => ec.EmbroideryId == id)
                    );
                    break;
                default:
                    break;
            }
            dbContext.SaveChanges();
        }
    }
}
