using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Shouaddr
    {
        public long Id { get; set; }
        public int Fesid { get; set; }
        public string Shouman { get; set; }
        public string Fname { get; set; }
        public string Sex { get; set; }
        public int ProvId { get; set; }
        public string Prov { get; set; }
        public int XianId { get; set; }
        public string Xian { get; set; }
        public string Addr { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string Bak { get; set; }
        public bool IsDefault { get; set; }
        public string AddrTag { get; set; }
        public string AddrText { get; set; }
    }
}
