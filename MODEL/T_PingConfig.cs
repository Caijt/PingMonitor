using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceMonitor.MODEL
{
    class T_PingConfig
    {
        public int ID { get; set; }
        public bool ISLOG { get; set; }
        public bool ISMAIL { get; set; }
        public int ALARMVALUE { get;set; }
        public int NETCOUNT { get; set; }
        public int TIMEOUTCOUNT { get; set; }
    }
}
