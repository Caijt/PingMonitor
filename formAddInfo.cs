using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PingMonitor
{
    public partial class formAddInfo : Form
    {
        public string mailAddress = "";
        public formAddInfo()
        {
            InitializeComponent();
        }

        private void formAddInfo_Load(object sender, EventArgs e)
        {
            txtMailAdd.Text = mailAddress;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mailAddress = txtMailAdd.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
