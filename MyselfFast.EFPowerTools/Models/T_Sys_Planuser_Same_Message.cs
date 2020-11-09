using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Planuser_Same_Message
    {
        public int Id { get; set; }
        public int Linkid { get; set; }
        public System.DateTime Checkdate { get; set; }
        public System.DateTime Gendate { get; set; }
        public int State { get; set; }
        public string Message { get; set; }
    }
}
