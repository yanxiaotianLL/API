using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_OrderWrap
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public string Des { get; set; }
        public Nullable<System.DateTime> VisitsStartTime { get; set; }
        public Nullable<System.DateTime> VisitsEndTime { get; set; }
        public Nullable<int> Fesid { get; set; }
        public Nullable<int> IsExemptPaperBill { get; set; }
        public string PdfSummary { get; set; }
        public string PdfDetailed { get; set; }
    }
}
