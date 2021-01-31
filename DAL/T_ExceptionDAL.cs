using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using PingMonitor.MODEL;

namespace PingMonitor.DAL
{
    class T_ExceptionDAL
    {
        public int Update(T_Exception modelIn)
        {
            string cmdStr = "update T_Exception set ISMAIL=@ISMAIL,ISLOG=@ISLOG,ISREMIND=@ISREMIND,TIMESPAN=@TIMESPAN,SPEEDRETIME=@SPEEDRETIME,SPEEDCOUNT=@SPEEDCOUNT,NONETCOUNT=@NONETCOUNT where ID=@ID";
            OleDbParameter[] parms ={
                                     new OleDbParameter("ISMAIL",modelIn.ISMAIL),
                                     new OleDbParameter("ISLOG",modelIn.ISLOG),
                                     new OleDbParameter("ISREMIND",modelIn.ISREMIND),
                                     new OleDbParameter("TIMESPAN",modelIn.TIMESPAN),
                                     new OleDbParameter("SPEEDRETIME",modelIn.SPEEDRETIME),
                                     new OleDbParameter("SPEEDCOUNT",modelIn.SPEEDCOUNT),
                                     new OleDbParameter("NONETCOUNT",modelIn.NONETCOUNT),            
                                     new OleDbParameter("ID",modelIn.ID)   
                                 };
             return SQLHelpler.ExecuteNonQuery(cmdStr,parms);
        }
        public T_Exception Get()
        {
            string cmdStr = "select * from T_Exception";
            DataRow dr = SQLHelpler.ExecuteAdapter(cmdStr).Rows[0];
            return ToModel(dr);
        }

        private T_Exception ToModel(DataRow dr)
        {
            T_Exception model = new T_Exception();
            model.ID = (int)dr["ID"];
            model.ISMAIL = (bool)dr["ISMAIL"];
            model.ISLOG = (bool)dr["ISLOG"];
            model.ISREMIND = (bool)dr["ISREMIND"];
            model.TIMESPAN = (int)dr["TIMESPAN"];
            model.SPEEDRETIME = (int)dr["SPEEDRETIME"];
            model.SPEEDCOUNT = (int)dr["SPEEDCOUNT"];
            model.NONETCOUNT = (int)dr["NONETCOUNT"];
            return model;
        }
    }
}
