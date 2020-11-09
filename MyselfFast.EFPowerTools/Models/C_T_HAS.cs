using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class C_T_HAS
    {
        public int Orderid { get; set; }
        public int FenType { get; set; }
        public Nullable<decimal> Mnypay { get; set; }
        public Nullable<decimal> Fenpay { get; set; }
    }
}
