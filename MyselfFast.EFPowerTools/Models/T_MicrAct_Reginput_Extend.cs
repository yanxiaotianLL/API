using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Reginput_Extend
    {
        public int ID { get; set; }
        public Nullable<int> ActiveID { get; set; }
        public Nullable<int> InputType { get; set; }
        public string InputLabel { get; set; }
        public string InputValue { get; set; }
        public Nullable<bool> IsRequired { get; set; }
        public Nullable<bool> Enable { get; set; }
        public Nullable<int> InputSort { get; set; }
        public Nullable<int> PersonIndex { get; set; }
        public string Description { get; set; }
        public Nullable<int> FieldType { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}
