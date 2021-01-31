using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ServiceMonitor.MODEL;

namespace ServiceMonitor.DAL
{
    class T_PingConfigDAL
    {
        public T_PingConfig Get()
        {
            string cmdStr = "select * from T_PingConfig";
            DataRow dr = SQLHelpler.ExecuteAdapter(cmdStr).Rows[0];
            T_PingConfig model = new T_PingConfig();
            model.ID = (int)dr["ID"];
            model.ISLOG = (bool)dr["ISLOG"];
            model.ISMAIL = (bool)dr["ISMAIL"];
            model.ALARMVALUE = (int)dr["ALARMVALUE"];
            return model;
        }
    }
}
