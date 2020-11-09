using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Cardnote
    {
        public int Id { get; set; }
        public string Cardnum { get; set; }
        public int Aid { get; set; }
        public int Fesid { get; set; }
        public int FenTag { get; set; }
        public decimal Fen { get; set; }
        public string FenStans { get; set; }
        public int Causeid { get; set; }
        public string Cause { get; set; }
        public string Bak { get; set; }
        public System.DateTime Gendate { get; set; }
        public int Fstate { get; set; }
        public int Operid { get; set; }
        public string Oper { get; set; }
        public System.DateTime Opertime { get; set; }
        public bool IsCommit { get; set; }
    }
}
