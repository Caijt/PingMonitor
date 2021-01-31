using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Mail;

using PingMonitor.BLL;
using PingMonitor.MODEL;
using System.Net;


namespace PingMonitor
{
    delegate void DelegateUpdateLst(ListViewItem itemIn, int timeIn);
    delegate void DelegateExecption(NetState modelIn);

    public partial class formMain : Form
    {
        bool isMail;
        bool isLog;
        bool isRemind;
        int SpeedReTime;
        int SpeedCount;
        int NoNetCount;
        int TimeSpan;
        string curName;

        DateTime lastTime;


        bool isMon;
        List<Thread> thList;

        T_PingObjBLL bllObj;
        T_ExceptionBLL bllExce;
        T_LogBLL bllLog;

        public formMain()
        {
            InitializeComponent();
            bllObj = new T_PingObjBLL();
            thList = new List<Thread>();
            bllExce = new T_ExceptionBLL();
            bllLog = new T_LogBLL();
        }
        private bool OpenForm(string formName)
        {
            foreach (Form formTemp in Application.OpenForms)
            {
                if (formTemp.Name == formName)
                {
                    formTemp.Activate();
                    return true;
                }
            }
            return false;
        }

        private void mailConfig_Click(object sender, EventArgs e)
        {
            if (!OpenForm("formMailConfig"))
            {
                formMailConfig formMail = new formMailConfig();
                formMail.Show();
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lastTime = DateTime.MinValue;
            curName = "";
            lstvResults.Items.Clear();
            isMon = true;
            T_Exception modelExce = bllExce.Get();

            isMail = modelExce.ISMAIL;
            isLog = modelExce.ISLOG;
            isRemind = modelExce.ISREMIND;
            TimeSpan = modelExce.TIMESPAN;
            SpeedReTime = modelExce.SPEEDRETIME;
            SpeedCount = modelExce.SPEEDCOUNT;
            NoNetCount = modelExce.NONETCOUNT;
            
            foreach (T_PingObj modelTemp in bllObj.GetByMonitor())
            {
                ListViewItem itemTemp = new ListViewItem();
                itemTemp.Tag = modelTemp;
                itemTemp.Text = modelTemp.OBJNAME;
                itemTemp.SubItems.Add(modelTemp.ADDRESS);
                itemTemp.SubItems.Add("未知");
                itemTemp.SubItems.Add("未知");
                itemTemp.SubItems.Add("未知");
                lstvResults.Items.Add(itemTemp);
                Thread th = new Thread(new ParameterizedThreadStart(ThreadPing));
                th.IsBackground = true;
                thList.Add(th);
                th.Start(itemTemp);
            }
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            ni.Text += "<监控中>";
        }
        //线程开始方法
        private void ThreadPing(object ObjIn)
        {
            ListViewItem itemTemp = (ListViewItem)ObjIn;
            T_PingObj modelObj = (T_PingObj)itemTemp.Tag;
            NetState model = new NetState();
            model.name = itemTemp.Text;
            model.ip = itemTemp.SubItems[1].Text;

            string targetIp = itemTemp.SubItems[1].Text;
            int noNetCount = 0;
            int slowSpeedCount = 0;
            int reTime = 0;
            bool isConvertIP = false;

            Ping p = new Ping();
            DelegateUpdateLst updateLst = new DelegateUpdateLst(UpdateLst);
            while (isMon)
            {
                if (!isConvertIP)
                {
                    try
                    {
                        targetIp = Dns.GetHostAddresses(targetIp)[0].ToString();                         
                        isConvertIP = true;
                    }
                    catch
                    {
                        reTime = -2;
                    }
                }
                if (isConvertIP)
                {
                    PingReply pr = p.Send(targetIp, 5000);
                    if (pr.Status == IPStatus.Success)
                    {

                        reTime = Convert.ToInt32(pr.RoundtripTime);
                        //下面是监控网速
                        if (modelObj.MONITORSPEED)
                        {
                            if (reTime >= SpeedReTime)
                            {
                                slowSpeedCount++;
                                if (slowSpeedCount >= SpeedCount)
                                {
                                    DelegateExecption Exce = new DelegateExecption(ExecptionHandle);
                                    model.reTime = reTime;
                                    model.state = "网速很慢";
                                    this.Invoke(Exce, model);
                                    slowSpeedCount = 0;
                                }
                            }
                            else
                            {
                                slowSpeedCount = 0;
                            }
                        }
                        noNetCount = 0;
                    }
                    else
                    {
                        reTime = -1;
                        //下面是监控断网
                        if (modelObj.MONITORNET)
                        {
                            noNetCount++;
                            if (noNetCount >= NoNetCount)
                            {

                                DelegateExecption exceptionHandle = new DelegateExecption(ExecptionHandle);
                                model.state = "断网";
                                model.reTime = -1;
                                this.Invoke(exceptionHandle, model);
                                noNetCount = 0;
                                //这里发送邮件
                            }
                        }
                    }
                }
                lstvResults.Invoke(updateLst, itemTemp, reTime);
                Thread.Sleep(1000);
            }
        }
        //子线程通过UI线程修改
        private void UpdateLst(ListViewItem itemIn, int timeIn)
        {
            string timeout = timeIn.ToString();
            string speed = "";
            string state = "正常";
            itemIn.BackColor = Color.White;
            if (timeIn == -2)
            {
                timeout = "超时";
                speed = "无";
                state = "找不到目标主机";
                itemIn.BackColor = Color.Blue;
            }
            else if (timeIn == -1)
            {
                timeout = "超时";
                speed = "无";
                state = "断网";
                itemIn.BackColor = Color.Red;
            }
            else if (timeIn < 100)
            {
                speed = "快";
            }
            else if (timeIn < 500)
            {
                speed = "普通";
            }
            else if (timeIn >= 500)
            {
                speed = "很慢";
                itemIn.BackColor = Color.Yellow;
            }
            itemIn.SubItems[2].Text = timeout;
            itemIn.SubItems[3].Text = speed;
            itemIn.SubItems[4].Text = state;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //foreach (Thread thTemp in thList)
            //{
            //    thTemp.Abort();
            //}
            isMon = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            ni.Text = "Ping监控";
        }
        //异常触发时事件
        private void ExecptionHandle(NetState modelIn)
        {
            if (isRemind)
            {
                ni.ShowBalloonTip(2000, modelIn.state, modelIn.name, ToolTipIcon.Warning);
            }
            if (isMail)
            {
                if ((DateTime.Now - lastTime).TotalMinutes >= TimeSpan||curName !=modelIn.name)
                {
                    formSend fs = new formSend() { modelIn = modelIn };                    
                    fs.SendMail();
                    lastTime = DateTime.Now;
                    curName = modelIn.name;
                }
            }
            if (isLog)
            {
                T_Log modelLog = new T_Log() { LOGTIME = DateTime.Now, OBJNAME = modelIn.name, ADDRESS = modelIn.ip, STATE = modelIn.state, RETIME = modelIn.reTime };
                bllLog.Add(modelLog);
                //MessageBox.Show("记录");
            }

        }

        private void 监控对象ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenForm("formObj"))
            {
                formObj formObj = new formObj();
                formObj.Show();
            }
        }

        private void 异常处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OpenForm("formException"))
            {
                formException formExce = new formException();
                formExce.Show();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!OpenForm("formLog"))
            {
                formLog formLog = new formLog();
                formLog.Show();
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon1;
        }

        private void formMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                ni.ShowBalloonTip(1, "注意", "单击弹出窗口", ToolTipIcon.Info);
            }
        }       
        private void ni_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!OpenForm("formAbout"))
            {
                formAbout formAb=new formAbout();
                formAb.Show();
            }
        }        
    }
}
