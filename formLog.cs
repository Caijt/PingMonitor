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
    public partial class formLog : Form
    {
        T_LogBLL bll;
        //T_Log model;
        public formLog()
        {
            InitializeComponent();
            bll = new T_LogBLL();
        }

        private void formLog_Load(object sender, EventArgs e)
        {
            dgvwResults.DataSource = bll.GetAll();
        }

        private void dgvwResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right&&e.RowIndex>=0)
            {
                dgvwResults.CurrentCell = dgvwResults[e.ColumnIndex<0?1:e.ColumnIndex, e.RowIndex];
                cms.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 删除日志记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listId = new List<string>();
            foreach (DataGridViewRow drTemp in dgvwResults.SelectedRows)
            {
                listId.Add(drTemp.Cells[0].Value.ToString());
                dgvwResults.Rows.Remove(drTemp);
            }
            MessageBox.Show("删除"+bll.DelAny(listId.ToArray()).ToString()+"条日志记录");
        }
    }
}
