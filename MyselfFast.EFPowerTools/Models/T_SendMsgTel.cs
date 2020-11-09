using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_SendMsgTel
    {
        public int Id { get; set; }
        public string TelName { get; set; }
        public string TelNumber { get; set; }
        public System.DateTime Createtime { get; set; }
        public int Hno { get; set; }
    }
}
