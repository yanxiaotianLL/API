using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_S_Blacklist
    {
        public int ID { get; set; }
        public int Fesid { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int State { get; set; }
        public int SysUser { get; set; }
    }
}
