using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_Zheng_Interface
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int MainPlanid { get; set; }
        public System.DateTime Subtime { get; set; }
        public int State { get; set; }
    }
}
