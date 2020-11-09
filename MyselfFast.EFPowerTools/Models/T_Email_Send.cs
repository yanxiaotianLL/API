using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Email_Send
    {
        public int ID { get; set; }
        public string TITEL { get; set; }
        public string CONTENT { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime SENDTIME { get; set; }
        public int SENDSTATE { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime PlanTime { get; set; }
    }
}
