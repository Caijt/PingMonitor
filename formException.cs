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
    public partial class formException : Form
    {
        T_ExceptionBLL bll;
        T_Exception model;
        public formException()
        {
            InitializeComponent();
            bll = new T_ExceptionBLL();
            model = bll.Get();
        }
        private void formException_Load(object sender, EventArgs e)
        {
            chkMail.Checked = model.ISMAIL;
            chkLog.Checked = model.ISLOG;
            chkRemind.Checked = model.ISREMIND;
            txtTimeSpan.Value = model.TIMESPAN;
            txtSpeedReTime.Value = model.SPEEDRETIME;
            txtSpeedCount.Value = model.SPEEDCOUNT;
            txtNoNetCount.Value = model.NONETCOUNT;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            model.ISMAIL = chkMail.Checked;
            model.ISLOG = chkLog.Checked;
            model.ISREMIND = chkRemind.Checked;
            model.TIMESPAN = Convert.ToInt32(txtTimeSpan.Value);
            model.SPEEDRETIME = Convert.ToInt32(txtSpeedReTime.Value);
            model.SPEEDCOUNT = Convert.ToInt32(txtSpeedCount.Value);
            model.NONETCOUNT = Convert.ToInt32(txtNoNetCount.Value);            
            MessageBox.Show("数据保存"+(bll.Update(model)?"成功":"失败")+"\r\n必须重新开始监控，设置才会生效。","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
