using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SECRM.Forms
{
    public partial class frmClientAdd : Form
    {
        public frmClientAdd()
        {
            InitializeComponent();
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientName.Text))
                btnSave.Enabled = true;
        }
    }
}
