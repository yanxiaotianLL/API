using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_OrderWrapItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int OrderWrapID { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> IsFen { get; set; }
    }
}
