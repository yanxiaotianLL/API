using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Mem_Benefityouhui
    {
        public int Id { get; set; }
        public string Discount { get; set; }
        public string Depart { get; set; }
        public string Yewubuuser { get; set; }
        public string Oper { get; set; }
        public int OperId { get; set; }
        public System.DateTime Indate { get; set; }
        public int Times { get; set; }
        public bool State { get; set; }
    }
}
