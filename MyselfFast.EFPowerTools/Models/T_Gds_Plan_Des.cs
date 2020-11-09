using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Plan_Des
    {
        public int Id { get; set; }
        public int Planid { get; set; }
        public string PlanName { get; set; }
        public int Hid { get; set; }
        public string Cname { get; set; }
        public string Description { get; set; }
    }
}
