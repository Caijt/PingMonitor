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
    public partial class formObj : Form
    {
        T_PingObjBLL bll;
        T_PingObj model;

        BindingSource bs;
        public formObj()
        {
            InitializeComponent();
            bll = new T_PingObjBLL();
            model = new T_PingObj();
            bs = new BindingSource();
        }

        private void formObj_Load(object sender, EventArgs e)
        {
            bs.DataSource = bll.GetAll();
            dgvwResults.DataSource = bs;

        }

        private void dgvwResults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(((T_PingObj)bs.Current).ToString());

            model = (T_PingObj)bs.Current;
            if (model.ID == 0)
            {
                model.ID = bll.Add(model);
            }
            else
            {
                bll.Update(model);
            }
            //bll.Update((T_PingObj)bs.Current);
        }       

        private void dgvwResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right&&e.RowIndex>=0)
            {
                dgvwResults.CurrentCell = dgvwResults[e.ColumnIndex<0?1:e.ColumnIndex, e.RowIndex];
                dgvwResults.CurrentCell.OwningRow.Selected = true;
                cms.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model = (T_PingObj)bs.Current;
            if (model.ID != 0)
            {
                bll.Del(model.ID);
                bs.RemoveCurrent();                
            }
        }        
    }
}
