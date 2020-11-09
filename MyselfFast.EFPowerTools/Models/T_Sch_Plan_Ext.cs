using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_Plan_Ext
    {
        public int Id { get; set; }
        public int Planid { get; set; }
        public decimal Price { get; set; }
        public decimal Costprice { get; set; }
        public int Interrate { get; set; }
        public long PriceId { get; set; }
        public bool Bckmnyable { get; set; }
        public string Calculation { get; set; }
    }
}
