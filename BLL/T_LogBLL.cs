using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PingMonitor.MODEL;
using PingMonitor.DAL;

namespace PingMonitor.BLL
{
    class T_LogBLL
    {
        public int DelAny(string[] ids)
        {
            return new T_LogDAL().DelAny(ids);
        }
        public int Add(T_Log modelIn)
        {
            return new T_LogDAL().Add(modelIn);
        }
        public DataTable GetAll()
        {
            return new T_LogDAL().GetAll();
        }
    }
}
