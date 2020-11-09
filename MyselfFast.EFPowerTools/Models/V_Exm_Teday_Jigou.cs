using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Exm_Teday_Jigou
    {
        public int Id { get; set; }
        public int JigouId { get; set; }
        public int CheckDate { get; set; }
        public int Thisdaynum { get; set; }
        public int Lastdaynum { get; set; }
        public int BeforeDay { get; set; }
        public int Thisdaynum_Ind { get; set; }
        public int Lastdaynum_Ind { get; set; }
        public int appnum_male { get; set; }
        public int appnum_female { get; set; }
        public string JiGouName { get; set; }
    }
}
