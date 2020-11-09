using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_OrderAndWrap_Info
    {
        public string OrderWrapCode { get; set; }
        public Nullable<int> OrderWrapState { get; set; }
        public int ID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string OrderNo { get; set; }
        public System.DateTime SeeDateBin { get; set; }
        public int ForPersonType { get; set; }
        public int OrderState { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Fesid { get; set; }
        public Nullable<bool> OrderIsDelete { get; set; }
        public Nullable<bool> WrapIsDelete { get; set; }
        public Nullable<System.DateTime> WrapCreateTime { get; set; }
        public double RealAmount { get; set; }
    }
}
