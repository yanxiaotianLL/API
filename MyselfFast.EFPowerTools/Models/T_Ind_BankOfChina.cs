using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_BankOfChina
    {
        public int Id { get; set; }
        public int FseId { get; set; }
        public int CardStatus { get; set; }
        public int State { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int FormalityId { get; set; }
        public int CardNumberIsValid { get; set; }
        public int TransactionMode { get; set; }
        public string Phone { get; set; }
        public string ReceiveAddress { get; set; }
        public string PostCode { get; set; }
    }
}
