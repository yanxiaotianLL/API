using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Pay
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Fid { get; set; }
        public int Fentype { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public decimal Fenpay { get; set; }
        public decimal Mnypay { get; set; }
        public decimal NoMnyPart { get; set; }
        public decimal RealFenpay { get; set; }
        public decimal RealCard { get; set; }
        public decimal RealMnypay { get; set; }
        public decimal BackFen { get; set; }
        public decimal BackCard { get; set; }
        public decimal BackMny { get; set; }
        public decimal Yunfei { get; set; }
    }
}
