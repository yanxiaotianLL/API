using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Costs
    {
        public int Id { get; set; }
        public int Danid { get; set; }
        public string Danno { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public System.DateTime Gendate { get; set; }
        public int State { get; set; }
    }
}
