using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PingMonitor.MODEL;
using PingMonitor.BLL;

namespace PingMonitor
{
    public partial class formMailConfig : Form
    {
        T_MailConfigBLL bllCon;
        T_MailConfig modelCon;

        T_MailAddressBLL bllAdd;
        T_MailAddress modelAdd;
        public formMailConfig()
        {
            InitializeComponent();
        }

        private void btnMailTest_Click(object sender, EventArgs e)
        {
            formSend s = new formSend() { modelIn = new NetState() };
            s.SendMail();
        }

        private void formMailConfig_Load(object sender, EventArgs e)
        {
            bllCon = new T_MailConfigBLL();
            modelCon = bllCon.Get();

            chkShow.Checked = modelCon.ISSHOW;
            txtSendMail.Text = modelCon.SENDMAIL;
            txtSender.Text = modelCon.SENDER;
            txtSendSMTP.Text = modelCon.SENDSMTP;
            txtSendPort.Text = modelCon.SENDPORT.ToString();
            txtUser.Text = modelCon.SENDUSER;
            txtPwd.Text = modelCon.SENDPWD;

            txtTitle.Text = modelCon.MAILTITLE;
            txtBody.Text = modelCon.MAILBODY;

            bllAdd = new T_MailAddressBLL();
            foreach (T_MailAddress modelTemp in bllAdd.GetAll())
            {
                lstAddress.Items.Add(modelTemp);
                lstAddress.DisplayMember = "MAILADDRESS";
                lstAddress.ValueMember = "ID";
            }

        }

        private void lstAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelAdd = (T_MailAddress)lstAddress.SelectedItem;
        }

        private void lstAddress_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formAddInfo formInfo = new formAddInfo() { mailAddress = lstAddress.Text };
            formInfo.ShowDialog();
        }

        private void btnAddressAdd_Click(object sender, EventArgs e)
        {
            formAddInfo formInfo = new formAddInfo();
            if (formInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                modelAdd = new T_MailAddress() { MAILADDRESS = formInfo.mailAddress };
                modelAdd.ID = bllAdd.Add(modelAdd);
                lstAddress.Items.Add(modelAdd);
                lstAddress.SelectedItem = modelAdd;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modelCon.ISSHOW = chkShow.Checked;
            modelCon.SENDMAIL = txtSendMail.Text;
            modelCon.SENDER = txtSender.Text;
            modelCon.SENDSMTP = txtSendSMTP.Text;
            modelCon.SENDPORT = Convert.ToInt32(txtSendPort.Text);
            modelCon.SENDUSER = txtUser.Text;
            modelCon.SENDPWD = txtPwd.Text;
            modelCon.MAILTITLE = txtTitle.Text;
            modelCon.MAILBODY = txtBody.Text;
            MessageBox.Show("数据保存" + (bllCon.Update(modelCon) ? "成功" : "失败"));
        }

        private void btnAddressDel_Click(object sender, EventArgs e)
        {
            if (modelAdd != null)
            {
                MessageBox.Show("删除" + (bllAdd.Del(modelAdd.ID) ? "成功" : "失败"));
                lstAddress.Items.Remove(modelAdd);
            }
        }
    }
}
