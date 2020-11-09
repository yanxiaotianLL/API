using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_PosDrug
    {
        public int ID { get; set; }
        public int DrugId { get; set; }
        public int PosId { get; set; }
        public double Proportion { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
