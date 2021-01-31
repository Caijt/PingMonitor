namespace PingMonitor
{
    partial class formLog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvwResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除日志记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwResults)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvwResults
            // 
            this.dgvwResults.AllowUserToAddRows = false;
            this.dgvwResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvwResults.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvwResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwResults.Location = new System.Drawing.Point(0, 0);
            this.dgvwResults.Name = "dgvwResults";
            this.dgvwResults.ReadOnly = true;
            this.dgvwResults.RowHeadersWidth = 25;
            this.dgvwResults.RowTemplate.Height = 23;
            this.dgvwResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwResults.Size = new System.Drawing.Size(493, 342);
            this.dgvwResults.TabIndex = 0;
            this.dgvwResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvwResults_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LOGTIME";
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "记录时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OBJNAME";
            this.Column3.HeaderText = "名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ADDRESS";
            this.Column4.FillWeight = 140F;
            this.Column4.HeaderText = "地址";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "STATE";
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "状态";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "RETIME";
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "延迟(ms)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除日志记录ToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.ShowImageMargin = false;
            this.cms.Size = new System.Drawing.Size(128, 48);
            // 
            // 删除日志记录ToolStripMenuItem
            // 
            this.删除日志记录ToolStripMenuItem.Name = "删除日志记录ToolStripMenuItem";
            this.删除日志记录ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.删除日志记录ToolStripMenuItem.Text = "删除日志记录";
            this.删除日志记录ToolStripMenuItem.Click += new System.EventHandler(this.删除日志记录ToolStripMenuItem_Click);
            // 
            // formLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 342);
            this.Controls.Add(this.dgvwResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看日志";
            this.Load += new System.EventHandler(this.formLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwResults)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvwResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem 删除日志记录ToolStripMenuItem;
    }
}