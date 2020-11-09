using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Notice
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public System.DateTime WakeStart { get; set; }
        public System.DateTime WakeEnd { get; set; }
        public int State { get; set; }
    }
}
