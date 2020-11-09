using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_IndExm_Mail
    {
        public int ID { get; set; }
        public int UID { get; set; }
        public string ReceiveUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LatestSendTime { get; set; }
        public bool IsAllow { get; set; }
        public int SendCount { get; set; }
        public string EType { get; set; }
        public int EState { get; set; }
    }
}
