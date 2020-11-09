using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_MicrActiveRecord
    {
        public int ID { get; set; }
        public Nullable<int> ActiveID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Fenday { get; set; }
        public Nullable<System.DateTime> Pubtime { get; set; }
        public Nullable<int> ParentActiveID { get; set; }
        public string PromoCode { get; set; }
        public string JoinPerson { get; set; }
        public Nullable<decimal> Totalpay { get; set; }
        public Nullable<int> ApplyStatus { get; set; }
        public string BillContent { get; set; }
        public string BillReceiveTel { get; set; }
        public string BillReceiver { get; set; }
        public string BillSendAddress { get; set; }
        public string BillTitle { get; set; }
        public string subMicrPic { get; set; }
        public string subActiveName { get; set; }
        public string ActiveAddress { get; set; }
        public Nullable<int> Ischarge { get; set; }
        public string mainMicrPic { get; set; }
        public string mainActiveName { get; set; }
        public Nullable<bool> IsSubActive { get; set; }
        public Nullable<int> ActiveFrom { get; set; }
        public int HealthActiveType { get; set; }
    }
}
