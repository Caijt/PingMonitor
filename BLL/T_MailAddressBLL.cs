using System;
using System.Collections.Generic;
using System.Text;
using PingMonitor.MODEL;
using PingMonitor.DAL;

namespace PingMonitor.BLL
{
    class T_MailAddressBLL
    {
        public bool Del(int id)
        {
            if (new T_MailAddressDAL().Del(id) <= 0)
                return false;
            else
                return true;
        }
        public int Add(T_MailAddress modelIn)
        {
            return new T_MailAddressDAL().Add(modelIn);
        }
        public IList<T_MailAddress> GetAll()
        {
            return new T_MailAddressDAL().GetAll();
        }
    }
}
