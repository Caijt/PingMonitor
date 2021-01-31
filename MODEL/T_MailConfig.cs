using System;
using System.Collections.Generic;
using System.Text;

namespace PingMonitor.MODEL
{
    class T_MailConfig
    {
        public int ID { get; set; }
        public bool ISSHOW { get; set; }
        public string SENDMAIL { get; set; }
        public string SENDER { get; set; }
        public string SENDSMTP { get; set; }
        public int SENDPORT { get; set; }
        public string SENDUSER { get; set; }
        public string SENDPWD { get; set; }
        public string MAILTITLE { get; set; }
        public string MAILBODY { get; set; }
    }
}
