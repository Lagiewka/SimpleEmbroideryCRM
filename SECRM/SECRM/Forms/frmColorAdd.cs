using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SECRM.Forms
{
    public partial class frmColorAdd : Form
    {
        public frmColorAdd()
        {
            InitializeComponent();
        }

        private void txtColorName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColorName.Text))
                btnSave.Enabled = true;
        }
    }
}
