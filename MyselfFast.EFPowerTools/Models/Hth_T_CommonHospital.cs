using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_CommonHospital
    {
        public int ID { get; set; }
        public Nullable<int> H_ID { get; set; }
        public string Name { get; set; }
        public string Provice { get; set; }
        public string City { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    }
}
