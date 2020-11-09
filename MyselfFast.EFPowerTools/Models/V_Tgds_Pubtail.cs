using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Tgds_Pubtail
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public string Orderby { get; set; }
        public int Hid { get; set; }
        public int Ys1 { get; set; }
        public string Ys1name { get; set; }
        public int Ys2 { get; set; }
        public string Ys2name { get; set; }
        public decimal Price { get; set; }
        public decimal Extprice { get; set; }
        public decimal Weight { get; set; }
        public int Kucun { get; set; }
        public bool Isdelete { get; set; }
        public decimal Costprice { get; set; }
        public int Hiskucun { get; set; }
        public decimal Discountprice { get; set; }
        public decimal Basisprice { get; set; }
        public string Basisource { get; set; }
        public bool IsDefault { get; set; }
        public long bakhid { get; set; }
        public bool IsMonyOnly { get; set; }
        public long Idx { get; set; }
        public Nullable<decimal> DUIPRICE { get; set; }
    }
}
