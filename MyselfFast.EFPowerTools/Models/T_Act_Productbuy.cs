using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Productbuy
    {
        public int Id { get; set; }
        public System.Guid Parentguid { get; set; }
        public int Userid { get; set; }
        public string Productname { get; set; }
        public int Productid { get; set; }
        public int Buynum { get; set; }
        public decimal Price { get; set; }
        public decimal Totalprice { get; set; }
        public System.DateTime Subtime { get; set; }
        public int Fesid { get; set; }
    }
}
