using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Bas_Dayset
    {
        public int Id { get; set; }
        public System.DateTime Sdate { get; set; }
        public int Wday { get; set; }
        public int Idx { get; set; }
        public string DayScript { get; set; }
        public bool Isdelete { get; set; }
    }
}
