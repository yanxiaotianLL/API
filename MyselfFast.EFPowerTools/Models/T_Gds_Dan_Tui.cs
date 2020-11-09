using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Tui
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int Orderid { get; set; }
        public string OrderNo { get; set; }
        public decimal Mny { get; set; }
        public System.DateTime GenDate { get; set; }
        public int State { get; set; }
        public int Planid { get; set; }
    }
}
