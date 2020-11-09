using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Email_ins
    {
        public int Id { get; set; }
        public int Eid { get; set; }
        public int Fid { get; set; }
        public string pc { get; set; }
        public int State { get; set; }
        public int SendType { get; set; }
        public System.DateTime PlanTime { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
