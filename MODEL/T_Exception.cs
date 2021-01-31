using System;
using System.Collections.Generic;
using System.Text;

namespace PingMonitor.MODEL
{
    class T_Exception
    {
        public int ID { get; set; }
        public bool ISMAIL { get; set; }
        public bool ISLOG { get; set; }
        public bool ISREMIND { get; set; }
        public int TIMESPAN { get; set; }
        public int SPEEDRETIME { get; set; }
        public int SPEEDCOUNT { get; set; }
        public int NONETCOUNT { get; set; }
    }
}
