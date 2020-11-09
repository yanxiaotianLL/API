using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Msg
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string PhoneNum { get; set; }
        public string PhoneContent { get; set; }
        public string ElectType { get; set; }
        public string ElectSource { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int IsNowSend { get; set; }
        public System.DateTime SendTime { get; set; }
        public int SendType { get; set; }
        public int IsDelete { get; set; }
    }
}
