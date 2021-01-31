using System;
using System.Collections.Generic;
using System.Text;

namespace PingMonitor.MODEL
{
    class NetState
    {
        public string name { get; set; }
        public string ip { get; set; }
        public int reTime { get; set; }
        public string state { get; set; }
    }
}
