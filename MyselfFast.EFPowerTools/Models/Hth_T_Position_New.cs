using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Position_New
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> State { get; set; }
        public string Level { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    }
}
