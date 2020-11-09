using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_OneCardIns_Base
    {
        public string CardNum { get; set; }
        public string CardPass { get; set; }
        public int ServId { get; set; }
        public string Email { get; set; }
        public string Cid { get; set; }
        public string CName { get; set; }
        public string Borth { get; set; }
        public int PreDay { get; set; }
        public string PointDay { get; set; }
        public string FName { get; set; }
        public string SendType { get; set; }
        public string Mobile { get; set; }
        public string PC { get; set; }
    }
}
