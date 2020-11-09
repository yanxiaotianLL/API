using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Hospital
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PosId { get; set; }
        public int State { get; set; }
        public string HosNo { get; set; }
        public int HosType { get; set; }
        public int Note { get; set; }
    }
}
