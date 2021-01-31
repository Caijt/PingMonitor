using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using PingMonitor.MODEL;

namespace PingMonitor.DAL
{
    class T_MailConfigDAL
    {
        public int Update(T_MailConfig modelIn)
        {
            string cmdStr = "update T_MailConfig set ISSHOW=@ISSHOW,SENDMAIL=@SENDMAIL,SENDER=@SENDER,SENDSMTP=@SENDSMTP,SENDPORT=@SENDPORT,SENDUSER=@SENDUSER,SENDPWD=@SENDPWD,MAILTITLE=@MAILTITLE,MAILBODY=@MAILBODY where ID=@ID";
            //string cmdStr = string.Format("update T_MailConfig set SENDMAIL='{0}',SENDER='{1}',SENDSMTP='{2}',SENDPORT={3},SENDUSER='{4}',SENDPWD='{5}',MAILTITLE='{6}',MAILBODY='{7}' where ID={8}", modelIn.SENDMAIL, modelIn.SENDER, modelIn.SENDSMTP, modelIn.SENDPORT, modelIn.SENDUSER, modelIn.SENDPWD, modelIn.MAILTITLE, modelIn.MAILBODY, modelIn.ID);
            OleDbParameter[] parms ={
                                       new OleDbParameter("ISSHOW",modelIn.ISSHOW),
                                       new OleDbParameter("SENDMAIL",modelIn.SENDMAIL),
                                       new OleDbParameter("SENDER",modelIn.SENDER),
                                       new OleDbParameter("SENDSMTP",modelIn.SENDSMTP),
                                       new OleDbParameter("SENDPORT",modelIn.SENDPORT),
                                       new OleDbParameter("SENDUSER",modelIn.SENDUSER),
                                       new OleDbParameter("SENDPWD",modelIn.SENDPWD),
                                       new OleDbParameter("MAILTITLE",modelIn.MAILTITLE),
                                       new OleDbParameter("MAILBODY",modelIn.MAILBODY),
                                       new OleDbParameter("ID",modelIn.ID)
                                   };
            return SQLHelpler.ExecuteNonQuery(cmdStr, parms);
        }

        public T_MailConfig Get()
        {
            string cmdStr = "select * from T_MailConfig";
            DataRow dr = SQLHelpler.ExecuteAdapter(cmdStr).Rows[0];
            T_MailConfig model = new T_MailConfig();
            model.ID = (int)dr["ID"];
            model.ISSHOW = (bool)dr["ISSHOW"];
            model.SENDMAIL = (string)dr["SENDMAIL"];
            model.SENDER = (string)dr["SENDER"];
            model.SENDSMTP=(string)dr["SENDSMTP"];
            model.SENDPORT = (int)dr["SENDPORT"];
            model.SENDUSER = (string)dr["SENDUSER"];
            model.SENDPWD = (string)dr["SENDPWD"];
            model.MAILTITLE = (string)dr["MAILTITLE"];
            model.MAILBODY = (string)dr["MAILBODY"];
            return model;

        }
    }
}
