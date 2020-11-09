using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class D_JC_Address
    {
        public int Id { get; set; }
        public Nullable<double> area_id { get; set; }
        public Nullable<double> parent_id { get; set; }
        public string area_name { get; set; }
        public Nullable<double> creator_id { get; set; }
        public string creator_name { get; set; }
        public string remark { get; set; }
        public string area_type { get; set; }
        public string area_type_dic { get; set; }
        public string area_code { get; set; }
        public Nullable<double> leaf { get; set; }
        public string is_parent_menu { get; set; }
        public Nullable<double> level { get; set; }
        public Nullable<double> area_state { get; set; }
        public string area_state_dic { get; set; }
        public Nullable<double> area_nature { get; set; }
        public string area_nature_dic { get; set; }
        public Nullable<double> order { get; set; }
        public Nullable<double> @operator { get; set; }
        public Nullable<System.DateTime> oper_time { get; set; }
    }
}
