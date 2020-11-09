using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Whole_Tail
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
        public decimal Price { get; set; }
        public decimal Costprice { get; set; }
        public int Nums { get; set; }
        public int Sendstate { get; set; }
        public decimal Mnypay { get; set; }
        public decimal Fenpay { get; set; }
        public decimal InterRate { get; set; }
        public string Memo { get; set; }
        public string Calculation { get; set; }
        public long PriceId { get; set; }
    }
}
