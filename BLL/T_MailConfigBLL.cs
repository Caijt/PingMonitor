using System;
using System.Collections.Generic;
using System.Text;
using PingMonitor.MODEL;
using PingMonitor.DAL;

namespace PingMonitor.BLL
{
    class T_MailConfigBLL
    {
        public bool Update(T_MailConfig modelIn)
        {
            if (new T_MailConfigDAL().Update(modelIn) <= 0)
                return false;
            else
                return true;
        }
        public T_MailConfig Get()
        {
            return new T_MailConfigDAL().Get();
        }
    }
}
