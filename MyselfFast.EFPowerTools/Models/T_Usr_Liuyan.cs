using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Usr_Liuyan
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string Quest { get; set; }
        public System.DateTime Udate { get; set; }
        public string Asks { get; set; }
        public System.DateTime Ddate { get; set; }
        public int State { get; set; }
    }
}
