using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Hospital_New
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Grade { get; set; }
        public string Remark { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    }
}
