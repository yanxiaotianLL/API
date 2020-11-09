using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_PackageBag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Pay { get; set; }
        public string BriefInfo { get; set; }
        public string Year { get; set; }
        public string DuringTime { get; set; }
        public int Status { get; set; }
        public decimal CostPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
