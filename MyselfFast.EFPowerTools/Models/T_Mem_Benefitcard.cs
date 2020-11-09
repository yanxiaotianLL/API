using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Mem_Benefitcard
    {
        public int Id { get; set; }
        public string Cardnum { get; set; }
        public string Cardbak { get; set; }
        public string Cardpass { get; set; }
        public int Cardstatus { get; set; }
        public string Cardbumen { get; set; }
        public decimal Chushijifen { get; set; }
        public decimal Jifencur { get; set; }
        public System.DateTime Enddate { get; set; }
        public int Fesid { get; set; }
        public System.DateTime Inertdate { get; set; }
        public System.DateTime Bddate { get; set; }
        public string Fname { get; set; }
        public int busiCustId { get; set; }
        public int acceId { get; set; }
        public string CardType { get; set; }
        public string Email { get; set; }
        public string YewubuUser { get; set; }
        public string ProtocolType { get; set; }
        public string BillType { get; set; }
        public decimal FeesFor { get; set; }
        public decimal TaxesPrice { get; set; }
        public string PayStates { get; set; }
        public string PaymentTime { get; set; }
        public string Optype { get; set; }
        public string Opcause { get; set; }
        public string Bak { get; set; }
    }
}
