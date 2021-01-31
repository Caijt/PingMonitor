using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using PingMonitor.MODEL;

namespace PingMonitor.DAL
{
    class T_LogDAL
    {
        public int DelAny(string[] ids)
        {
            string whereStr = string.Join(",", ids);
            string cmdStr = "delete from T_Log where ID in ("+whereStr+")";
            return SQLHelpler.ExecuteNonQuery(cmdStr);
        }
        public int Add(T_Log modelIn)
        {
            string cmdStr = "insert into T_Log(LOGTIME,OBJNAME,ADDRESS,STATE,RETIME) values(@LOGTIME,@OBJNAME,@ADDRESS,@STATE,@RETIME)";
           
            OleDbParameter[] parms ={
                                       new OleDbParameter ("LOGTIME",modelIn.LOGTIME.ToString()),                                       
                                       new OleDbParameter ("OBJNAME",modelIn.OBJNAME),
                                       new OleDbParameter ("ADDRESS",modelIn.ADDRESS),
                                       new OleDbParameter ("STATE",modelIn.STATE),
                                       new OleDbParameter ("RETIME",modelIn.RETIME)                                      
                                   };
            return SQLHelpler.ExecuteNonQuery(cmdStr,parms);
        }
        public DataTable GetAll()
        {
            string cmdStr = "select * from T_Log order by ID desc";
            //List<T_Log> models = new List<T_Log>();
            //foreach (DataRow drTemp in SQLHelpler.ExecuteAdapter(cmdStr).Rows)
            //{
            //    ToModel(models, drTemp);
            //}
            //return models;
            return SQLHelpler.ExecuteAdapter(cmdStr);
        }

        private static void ToModel(List<T_Log> models, DataRow drTemp)
        {
            T_Log model = new T_Log();
            model.ID = (int)drTemp["ID"];
            model.LOGTIME = (DateTime)drTemp["TIME"];
            model.OBJNAME = (string)drTemp["OBJNAME"];
            model.ADDRESS = (string)drTemp["ADDRESS"];
            model.STATE = (string)drTemp["STATE"];
            model.RETIME = (int)drTemp["RETIME"];
            models.Add(model);
        }
    }
}
