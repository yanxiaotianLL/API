using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Imp_DefaultOrder_Tail
    {
        public int Id { get; set; }
        public int Pc { get; set; }
        public int Fesid { get; set; }
        public int State { get; set; }
        public string ErrorMsg { get; set; }
    }
}
