using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_PhoneCode
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Ip { get; set; }
        public string ToUser { get; set; }
        public int Sort { get; set; }
        public string FromUser { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UseTime { get; set; }
    }
}
