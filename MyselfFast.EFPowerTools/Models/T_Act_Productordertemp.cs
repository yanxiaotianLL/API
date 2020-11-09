using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Productordertemp
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public decimal Totalpay { get; set; }
        public System.DateTime Subtime { get; set; }
        public int Status { get; set; }
        public System.Guid Tguid { get; set; }
        public string Danno { get; set; }
        public string Shouman { get; set; }
        public string Shoutel { get; set; }
        public string Shouaddress { get; set; }
        public string Shoupost { get; set; }
        public int Sendtype { get; set; }
        public int Ispiao { get; set; }
        public string Piaotitle { get; set; }
        public string Piaouse { get; set; }
        public int Paytype { get; set; }
        public System.DateTime Paytime { get; set; }
        public int Fesid { get; set; }
    }
}
