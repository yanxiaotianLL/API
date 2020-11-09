using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Wei_TempMsg
    {
        public int ID { get; set; }
        public string SortName { get; set; }
        public string Title { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string EndText { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> SetSendTime { get; set; }
        public Nullable<System.DateTime> RealSendTime { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> OnlyNo { get; set; }
    }
}
