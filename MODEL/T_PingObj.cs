using System;
using System.Collections.Generic;
using System.Text;

namespace PingMonitor.MODEL
{
    class T_PingObj
    {
        public int ID { get; set; }
        public string OBJNAME { get; set; }
        public string ADDRESS { get; set; }
        public bool MONITORSPEED { get; set; }
        public bool MONITORNET { get; set; }
    }
}
