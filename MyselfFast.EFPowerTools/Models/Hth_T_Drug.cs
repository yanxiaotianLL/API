using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Drug
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double DefProportion { get; set; }
        public int Position { get; set; }
        public string DNumber { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
