using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Calendar
    {
        public int ID { get; set; }
        public int CYear { get; set; }
        public int CMonth { get; set; }
        public int CDay { get; set; }
        public bool IsWorkDay { get; set; }
    }
}
