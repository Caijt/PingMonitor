using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using PingMonitor.MODEL;

namespace PingMonitor.DAL
{
    class T_PingObjDAL
    {
        public int Del(int id)
        {
            string cmdStr = "delete from T_PingObj where ID=@ID";
            OleDbParameter parm = new OleDbParameter("ID", id);
            return SQLHelpler.ExecuteNonQuery(cmdStr, parm);
        }
        public int Add(T_PingObj modelIn)
        {
            string cmdStr = "insert into T_PingObj(OBJNAME,ADDRESS,MONITORSPEED,MONITORNET) values(@OBJNAME,@ADDRESS,@MONITORSPEED,@MONITORNET)";
            OleDbParameter[] parms ={
                                       new OleDbParameter("OBJNAME",modelIn.OBJNAME==null?"":modelIn.OBJNAME),
                                       new OleDbParameter("ADDRESS",modelIn.ADDRESS==null?"":modelIn.ADDRESS),
                                       new OleDbParameter("MONITORSPEED",modelIn.MONITORSPEED),
                                       new OleDbParameter("MONITORNET",modelIn.MONITORNET)
                                   };
            SQLHelpler.ExecuteNonQuery(cmdStr, parms);
            return (int)SQLHelpler.ExecuteSclary("select max(ID) from T_PingObj");
        }
        public int Update(T_PingObj modelIn)
        {
            string cmdStr = "update T_PingObj set OBJNAME=@OBJNAME,ADDRESS=@ADDRESS,MONITORSPEED=@MONITORSPEED,MONITORNET=@MONITORNET where ID=@ID";
            OleDbParameter[] parms ={
                                       new OleDbParameter("OBJNAME",modelIn.OBJNAME==null?"":modelIn.OBJNAME),
                                       new OleDbParameter("ADDRESS",modelIn.ADDRESS==null?"":modelIn.ADDRESS),
                                        new OleDbParameter("MONITORSPEED",modelIn.MONITORSPEED),
                                       new OleDbParameter("MONITORNET",modelIn.MONITORNET),
                                       new OleDbParameter("ID",modelIn.ID)
                                   };
            return SQLHelpler.ExecuteNonQuery(cmdStr, parms);
        }

        public IList<T_PingObj> GetByMonitor()
        {
            string cmdStr = "select * from T_PingObj where MONITORSPEED=true or MONITORNET=true";
            List<T_PingObj> models = new List<T_PingObj>();
            foreach (DataRow drTemp in SQLHelpler.ExecuteAdapter(cmdStr).Rows)
            {
                T_PingObj modelTemp = ToModel(drTemp);
                models.Add(modelTemp);
            }
            return models;
        }
        public IList<T_PingObj> GetAll()
        {
            string cmdStr = "select * from T_PingObj";
            List<T_PingObj> models = new List<T_PingObj>();
            foreach (DataRow drTemp in SQLHelpler.ExecuteAdapter(cmdStr).Rows)
            {
                T_PingObj modelTemp = ToModel(drTemp);
                models.Add(modelTemp);
            }
            return models;
        }

        private static T_PingObj ToModel(DataRow drTemp)
        {
            T_PingObj modelTemp = new T_PingObj();
            modelTemp.ID = (int)drTemp["ID"];
            modelTemp.OBJNAME = (string)drTemp["OBJNAME"];
            modelTemp.ADDRESS = (string)drTemp["ADDRESS"];
            modelTemp.MONITORSPEED = (bool)drTemp["MONITORSPEED"];
            modelTemp.MONITORNET = (bool)drTemp["MONITORNET"];
            return modelTemp;
        }
    }
}
