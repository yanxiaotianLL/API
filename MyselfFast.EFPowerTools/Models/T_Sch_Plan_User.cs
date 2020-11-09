using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_Plan_User
    {
        public int Id { get; set; }
        public int Planid { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int SchNum { get; set; }
        public int Buynum { get; set; }
        public System.DateTime LmtStart { get; set; }
        public System.DateTime LmtEnd { get; set; }
        public bool State { get; set; }
    }
}
