using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

using PingMonitor.MODEL;
using PingMonitor.BLL;

namespace PingMonitor
{
    partial class formSend : Form
    {
        int closeTime = 3;
        public NetState modelIn;

        SmtpClient smtp;
         
        public formSend()
        {
            InitializeComponent();
            
        }
        public void SendMail()
        {
            T_MailConfigBLL bllMailCon = new T_MailConfigBLL();
            T_MailConfig modelMailCon = bllMailCon.Get();
            if (modelMailCon.ISSHOW)
            {
                this.Show();
            }
            T_MailAddressBLL bllAdd = new T_MailAddressBLL();
            IList<T_MailAddress> modelsAdd = bllAdd.GetAll();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(modelMailCon.SENDMAIL, modelMailCon.SENDER);
            string title = modelMailCon.MAILTITLE.Replace("[name]", modelIn.name);
            title = title.Replace("[ip]", modelIn.ip);
            title = title.Replace("[state]", modelIn.state);
            title = title.Replace("[reTime]", modelIn.reTime == -1 ? "无" : modelIn.reTime.ToString());
            mail.Subject = title;
            string body = modelMailCon.MAILBODY.Replace("[name]", modelIn.name);
            body = body.Replace("[ip]", modelIn.ip);
            body = body.Replace("[state]", modelIn.state);
            body = body.Replace("[reTime]", modelIn.reTime == -1 ? "无" : modelIn.reTime.ToString());
            mail.Body = body;
            foreach (T_MailAddress modelTemp in modelsAdd)
            {
                mail.To.Add(modelTemp.MAILADDRESS);
            }
            smtp = new SmtpClient();
            smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
            smtp.Host = modelMailCon.SENDSMTP;
            smtp.Port = modelMailCon.SENDPORT;
            smtp.Credentials = new System.Net.NetworkCredential(modelMailCon.SENDUSER, modelMailCon.SENDPWD);
            smtp.SendAsync(mail, null);
        }        
        private void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                label1.Text = e.Error.Message;
            }
            else if (e.Cancelled)
            {
                label1.Text = "邮件已取消发送";               
            }
            else
            {
                label1.Text = "邮件已成功发送";                
            }            
            timer1.Enabled = true;
            btnCancel.Text = "关闭";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                smtp.SendAsyncCancel();
            }
            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (closeTime <= 0)
            {
                this.Close();
            }
            btnCancel.Text = closeTime + "秒后自动关闭窗口";
            closeTime--;           
            
        }
    }
}
