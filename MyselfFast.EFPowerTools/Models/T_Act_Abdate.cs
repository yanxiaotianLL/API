using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Abdate
    {
        public int Id { get; set; }
        public int Activeid { get; set; }
        public System.DateTime Baodate { get; set; }
        public int Nums { get; set; }
        public string Memo { get; set; }
        public bool Isdelete { get; set; }
        public int SignCountNums { get; set; }
    }
}
