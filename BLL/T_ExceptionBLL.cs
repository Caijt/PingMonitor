using System;
using System.Collections.Generic;
using System.Text;
using PingMonitor.MODEL;
using PingMonitor.DAL;

namespace PingMonitor.BLL
{
    class T_ExceptionBLL
    {
        public bool Update(T_Exception modelIn)
        {
            if (new T_ExceptionDAL().Update(modelIn) < 0)
                return false;
            else
                return true;
        }
        public T_Exception Get()
        {
            return new T_ExceptionDAL().Get();
        }
    }
}
