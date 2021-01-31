using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

using PingMonitor.MODEL;

namespace PingMonitor.DAL
{
    class T_MailAddressDAL
    {
        public int Del(int id)
        {
            string cmdStr = "delete from T_MailAddress where ID=@ID";
            OleDbParameter parm = new OleDbParameter("ID", id);
            return SQLHelpler.ExecuteNonQuery(cmdStr, parm);
        }
        public int Add(T_MailAddress modelIn)
        {
            string cmdStr = "insert into T_MailAddress(MAILADDRESS) values(@MAILADDRESS)";
            OleDbParameter parm = new OleDbParameter("MAILADDRESS", modelIn.MAILADDRESS);
            SQLHelpler.ExecuteNonQuery(cmdStr, parm);
            return (int)SQLHelpler.ExecuteSclary("select max(ID) from T_MailAddress");

        }
        public IList<T_MailAddress> GetAll()
        {
            string cmdStr = "select * from T_MailAddress";
            List<T_MailAddress> models = new List<T_MailAddress>();
            foreach (DataRow drTemp in SQLHelpler.ExecuteAdapter(cmdStr).Rows)
            {
                T_MailAddress modelTemp = new T_MailAddress();
                modelTemp.ID = (int)drTemp["ID"];
                modelTemp.MAILADDRESS = (string)drTemp["MAILADDRESS"];
                models.Add(modelTemp);
            }
            return models;
        }
    }
}
