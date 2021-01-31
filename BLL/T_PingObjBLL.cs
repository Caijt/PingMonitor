using System;
using System.Collections.Generic;
using System.Text;
using PingMonitor.MODEL;
using PingMonitor.DAL;

namespace PingMonitor.BLL
{
    class T_PingObjBLL
    {
        public int Del(int id)
        {
            return new T_PingObjDAL().Del(id);
        }
        public int Add(T_PingObj modelIn)
        {
            return new T_PingObjDAL().Add(modelIn);
        }
        public int Update(T_PingObj modelIn)
        {
            return new T_PingObjDAL().Update(modelIn);
        }
        public IList<T_PingObj> GetByMonitor()
        {
            return new T_PingObjDAL().GetByMonitor();
        }
        public IList<T_PingObj> GetAll()
        {
            return new T_PingObjDAL().GetAll();
        }
    }
}
