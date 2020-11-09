using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Fls_Fennote
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string Fno { get; set; }
        public decimal MnyPay { get; set; }
        public decimal Fen { get; set; }
        public decimal Fprice { get; set; }
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
        public string ProtocolType { get; set; }
        public string BillType { get; set; }
        public decimal FeesFor { get; set; }
        public decimal TaxesPrice { get; set; }
        public string PayStates { get; set; }
        public string PaymentTime { get; set; }
        public string Optype { get; set; }
        public string Opcause { get; set; }
        public string Pcid { get; set; }
    }
}
