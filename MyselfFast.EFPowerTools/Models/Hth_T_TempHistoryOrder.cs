using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_TempHistoryOrder
    {
        public int ID { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> OrderWrapID { get; set; }
        public string Code { get; set; }
        public Nullable<int> OrderStateOld { get; set; }
        public Nullable<int> OrderState { get; set; }
        public Nullable<int> OrderWrapState { get; set; }
    }
}
