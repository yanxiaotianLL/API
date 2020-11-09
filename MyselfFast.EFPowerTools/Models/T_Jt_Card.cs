using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Jt_Card
    {
        public int Id { get; set; }
        public string cardnum { get; set; }
        public string cardpass { get; set; }
        public string Fesid { get; set; }
        public int isuse { get; set; }
    }
}
