using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Power_ins_tail
    {
        public int Id { get; set; }
        public int Pcid { get; set; }
        public int Fesid { get; set; }
        public System.DateTime ImportTime { get; set; }
    }
}
