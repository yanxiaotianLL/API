using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_IndExm_Temp
    {
        public int ID { get; set; }
        public long ProdID { get; set; }
        public string ProdName { get; set; }
        public long ProScheID { get; set; }
        public string ProScheName { get; set; }
        public string TierCode { get; set; }
        public string TierName { get; set; }
        public string TierValue { get; set; }
        public int UseState { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> EditerID { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public Nullable<int> Createrid { get; set; }
        public string Remark { get; set; }
        public string SendMsg { get; set; }
    }
}
