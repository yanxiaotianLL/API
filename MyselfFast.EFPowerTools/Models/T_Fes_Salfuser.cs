using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Salfuser
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
        public int Fesid { get; set; }
        public int Verifyid { get; set; }
    }
}
