namespace PingMonitor
{
    partial class formException
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMail = new System.Windows.Forms.CheckBox();
            this.chkRemind = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoNetCount = new System.Windows.Forms.NumericUpDown();
            this.txtSpeedCount = new System.Windows.Forms.NumericUpDown();
            this.txtSpeedReTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoNetCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeedCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeedReTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMail);
            this.groupBox1.Controls.Add(this.chkRemind);
            this.groupBox1.Controls.Add(this.chkLog);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发生异常时";
            // 
            // chkMail
            // 
            this.chkMail.AutoSize = true;
            this.chkMail.Location = new System.Drawing.Point(12, 22);
            this.chkMail.Name = "chkMail";
            this.chkMail.Size = new System.Drawing.Size(72, 16);
            this.chkMail.TabIndex = 0;
            this.chkMail.Text = "发送邮件";
            this.chkMail.UseVisualStyleBackColor = true;
            // 
            // chkRemind
            // 
            this.chkRemind.AutoSize = true;
            this.chkRemind.Location = new System.Drawing.Point(12, 48);
            this.chkRemind.Name = "chkRemind";
            this.chkRemind.Size = new System.Drawing.Size(84, 16);
            this.chkRemind.TabIndex = 2;
            this.chkRemind.Text = "显示提示框";
            this.chkRemind.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(108, 22);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(72, 16);
            this.chkLog.TabIndex = 1;
            this.chkLog.Text = "记录日志";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(134, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(55, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNoNetCount);
            this.groupBox2.Controls.Add(this.txtSpeedCount);
            this.groupBox2.Controls.Add(this.txtSpeedReTime);
            this.groupBox2.Controls.Add(this.txtTimeSpan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "异常设置";
            // 
            // txtNoNetCount
            // 
            this.txtNoNetCount.Location = new System.Drawing.Point(134, 111);
            this.txtNoNetCount.Name = "txtNoNetCount";
            this.txtNoNetCount.Size = new System.Drawing.Size(58, 21);
            this.txtNoNetCount.TabIndex = 2;
            // 
            // txtSpeedCount
            // 
            this.txtSpeedCount.Location = new System.Drawing.Point(134, 82);
            this.txtSpeedCount.Name = "txtSpeedCount";
            this.txtSpeedCount.Size = new System.Drawing.Size(58, 21);
            this.txtSpeedCount.TabIndex = 1;
            // 
            // txtSpeedReTime
            // 
            this.txtSpeedReTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtSpeedReTime.Location = new System.Drawing.Point(134, 53);
            this.txtSpeedReTime.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtSpeedReTime.Name = "txtSpeedReTime";
            this.txtSpeedReTime.Size = new System.Drawing.Size(58, 21);
            this.txtSpeedReTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "网速触发延迟(ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "网速触发次数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "断网触发次数";
            // 
            // txtTimeSpan
            // 
            this.txtTimeSpan.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtTimeSpan.Location = new System.Drawing.Point(134, 22);
            this.txtTimeSpan.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtTimeSpan.Name = "txtTimeSpan";
            this.txtTimeSpan.Size = new System.Drawing.Size(58, 21);
            this.txtTimeSpan.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "邮件发送间隔(分钟)";
            // 
            // formException
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(210, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常处理设置";
            this.Load += new System.EventHandler(this.formException_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoNetCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeedCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeedReTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeSpan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.CheckBox chkMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtSpeedReTime;
        private System.Windows.Forms.NumericUpDown txtNoNetCount;
        private System.Windows.Forms.NumericUpDown txtSpeedCount;
        private System.Windows.Forms.CheckBox chkRemind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTimeSpan;
    }
}