using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace PingMonitor.DAL
{
    class SQLHelpler
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        #region select
        public static DataTable ExecuteAdapter(string cmdStr, params OleDbParameter[] Parms)
        {
            using (OleDbConnection oleDbCon = new OleDbConnection(conStr))
            {
                oleDbCon.Open();
                using (OleDbCommand oleDbCmd = new OleDbCommand(cmdStr, oleDbCon))
                {
                    oleDbCmd.Parameters.AddRange(Parms);
                    using (OleDbDataAdapter oleDbAda = new OleDbDataAdapter(oleDbCmd))
                    {
                        DataTable dtbl = new DataTable();
                        oleDbAda.Fill(dtbl);
                        return dtbl;
                    }
                }
            }
        }
        #endregion

        #region 删改
        public static int ExecuteNonQuery(string cmdStr, params OleDbParameter[] parms)
        {
            using (OleDbConnection sqlCon = new OleDbConnection(conStr))
            {
                sqlCon.Open();
                using (OleDbCommand sqlCmd = new OleDbCommand(cmdStr, sqlCon))
                {
                    sqlCmd.Parameters.AddRange(parms);
                    return sqlCmd.ExecuteNonQuery();
                }
            }

        }
        //增
        public static object ExecuteSclary(string cmdStr, params OleDbParameter[] parms)
        {
            using (OleDbConnection sqlCon = new OleDbConnection(conStr))
            {
                sqlCon.Open();
                using (OleDbCommand sqlCmd = new OleDbCommand(cmdStr, sqlCon))
                {
                    sqlCmd.Parameters.AddRange(parms);
                    return sqlCmd.ExecuteScalar();
                }
            }

        }
        #endregion
    }
}
