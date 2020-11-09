using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Safeuser_Ins
    {
        public int Id { get; set; }
        public int Hno { get; set; }
        public string Sname { get; set; }
        public string Mobiles { get; set; }
        public string Comno { get; set; }
        public string ComnoSub { get; set; }
        public int Fid { get; set; }
        public string Sex { get; set; }
        public string Cid { get; set; }
        public string Email { get; set; }
        public string Pc { get; set; }
        public System.DateTime InsDate { get; set; }
    }
}
