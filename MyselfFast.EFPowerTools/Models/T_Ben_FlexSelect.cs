using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ben_FlexSelect
    {
        public int ID { get; set; }
        public int PlanId { get; set; }
        public int FesID { get; set; }
        public int Count { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public Nullable<int> IsLock { get; set; }
    }
}
