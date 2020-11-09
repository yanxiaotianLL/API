using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class C_561_FEN_ERROR
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Fno { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string Uno { get; set; }
        public int Aid { get; set; }
        public int Pcid { get; set; }
        public int Fesid { get; set; }
        public int FenTag { get; set; }
        public decimal Fen { get; set; }
        public string FenStans { get; set; }
        public int Causeid { get; set; }
        public string Cause { get; set; }
        public string Bak { get; set; }
        public System.DateTime LmtSatrt { get; set; }
        public System.DateTime LmtEnd { get; set; }
        public System.DateTime Gendate { get; set; }
        public int Fstate { get; set; }
        public int Operid { get; set; }
        public string Oper { get; set; }
        public System.DateTime Opertime { get; set; }
        public bool IsCommit { get; set; }
        public decimal FeesFor { get; set; }
        public decimal TaxesPrice { get; set; }
        public string PayStates { get; set; }
        public string PaymentTime { get; set; }
        public string ProtocolType { get; set; }
        public string BillType { get; set; }
        public int Insfrom { get; set; }
    }
}
