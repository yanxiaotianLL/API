using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Whole_PayNote
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Payid { get; set; }
        public int AccountType { get; set; }
        public int AccountId { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public int Fentype { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public decimal Fen { get; set; }
        public decimal Backfen { get; set; }
    }
}
