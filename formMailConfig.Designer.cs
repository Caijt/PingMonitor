namespace PingMonitor
{
    partial class formMailConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSendMail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSendSMTP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddressDel = new System.Windows.Forms.Button();
            this.btnAddressAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAddress = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMailTest = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人邮箱";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSendMail
            // 
            this.txtSendMail.Location = new System.Drawing.Point(87, 20);
            this.txtSendMail.Name = "txtSendMail";
            this.txtSendMail.Size = new System.Drawing.Size(146, 21);
            this.txtSendMail.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSendPort);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSendSMTP);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPwd);
            this.tabPage1.Controls.Add(this.txtSender);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.txtSendMail);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发件人设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "发送端口";
            // 
            // txtSendPort
            // 
            this.txtSendPort.Location = new System.Drawing.Point(87, 102);
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(146, 21);
            this.txtSendPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "发送服务器";
            // 
            // txtSendSMTP
            // 
            this.txtSendSMTP.Location = new System.Drawing.Point(87, 75);
            this.txtSendSMTP.Name = "txtSendSMTP";
            this.txtSendSMTP.Size = new System.Drawing.Size(146, 21);
            this.txtSendSMTP.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "发件人";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(87, 157);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(146, 21);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(87, 48);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(146, 21);
            this.txtSender.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "登录名";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(87, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 21);
            this.txtUser.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddressDel);
            this.tabPage2.Controls.Add(this.btnAddressAdd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lstAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收件人设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddressDel
            // 
            this.btnAddressDel.Location = new System.Drawing.Point(38, 173);
            this.btnAddressDel.Name = "btnAddressDel";
            this.btnAddressDel.Size = new System.Drawing.Size(24, 23);
            this.btnAddressDel.TabIndex = 2;
            this.btnAddressDel.Text = "-";
            this.btnAddressDel.UseVisualStyleBackColor = true;
            this.btnAddressDel.Click += new System.EventHandler(this.btnAddressDel_Click);
            // 
            // btnAddressAdd
            // 
            this.btnAddressAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddressAdd.Location = new System.Drawing.Point(8, 173);
            this.btnAddressAdd.Name = "btnAddressAdd";
            this.btnAddressAdd.Size = new System.Drawing.Size(24, 23);
            this.btnAddressAdd.TabIndex = 1;
            this.btnAddressAdd.Text = "+";
            this.btnAddressAdd.UseVisualStyleBackColor = true;
            this.btnAddressAdd.Click += new System.EventHandler(this.btnAddressAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "收件人列表";
            // 
            // lstAddress
            // 
            this.lstAddress.FormattingEnabled = true;
            this.lstAddress.ItemHeight = 12;
            this.lstAddress.Location = new System.Drawing.Point(8, 20);
            this.lstAddress.Name = "lstAddress";
            this.lstAddress.Size = new System.Drawing.Size(253, 148);
            this.lstAddress.TabIndex = 0;
            this.lstAddress.SelectedIndexChanged += new System.EventHandler(this.lstAddress_SelectedIndexChanged);
            this.lstAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAddress_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBody);
            this.tabPage3.Controls.Add(this.txtTitle);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(267, 202);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "邮件内容设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(13, 52);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(240, 136);
            this.txtBody.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(70, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(183, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "邮件正文";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮件标题";
            // 
            // btnMailTest
            // 
            this.btnMailTest.Location = new System.Drawing.Point(4, 261);
            this.btnMailTest.Name = "btnMailTest";
            this.btnMailTest.Size = new System.Drawing.Size(87, 23);
            this.btnMailTest.TabIndex = 1;
            this.btnMailTest.Text = "发送测试邮件";
            this.btnMailTest.UseVisualStyleBackColor = true;
            this.btnMailTest.Click += new System.EventHandler(this.btnMailTest_Click);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(7, 5);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(96, 16);
            this.chkShow.TabIndex = 3;
            this.chkShow.Text = "弹出发送窗口";
            this.chkShow.UseVisualStyleBackColor = true;
            // 
            // formMailConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(283, 288);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMailTest);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formMailConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件设置";
            this.Load += new System.EventHandler(this.formMailConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSendMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSendSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAddress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddressAdd;
        private System.Windows.Forms.Button btnMailTest;
        private System.Windows.Forms.Button btnAddressDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkShow;
    }
}