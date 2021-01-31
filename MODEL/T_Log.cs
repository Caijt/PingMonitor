using System;
using System.Collections.Generic;
using System.Text;

namespace PingMonitor.MODEL
{
    class T_Log
    {
        public int ID { get; set; }
        public DateTime LOGTIME { get; set; }
        public string OBJNAME { get; set; }
        public string ADDRESS { get; set; }
        public string STATE { get; set; }
        public int RETIME { get; set; }
    }
}
