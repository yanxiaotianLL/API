using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Jurisdiction
    {
        public int ID { get; set; }
        public Nullable<int> Pid { get; set; }
        public Nullable<int> Custid { get; set; }
        public Nullable<int> Busicustid { get; set; }
        public Nullable<int> Conid { get; set; }
        public Nullable<int> Acceid { get; set; }
        public string Note { get; set; }
        public Nullable<bool> HasHealth { get; set; }
        public Nullable<bool> IsExemptPaperBill { get; set; }
        public string PaperBillAmount { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> NoEntityCreateTime { get; set; }
        public Nullable<int> LimitTotalCount { get; set; }
        public Nullable<decimal> LimitTotalAmount { get; set; }
        public Nullable<bool> LimitIsEnable { get; set; }
        public Nullable<System.DateTime> LimitCreateDate { get; set; }
    }
}
