using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_FenBakFesco_Log
    {
        public int Id { get; set; }
        public int Pcid { get; set; }
        public int Fid { get; set; }
        public string Fno { get; set; }
        public decimal Fen { get; set; }
        public string AuditBak { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
