using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_AskCause
    {
        public int Id { get; set; }
        public int Hid { get; set; }
        public string Cause { get; set; }
        public int Ctype { get; set; }
        public int State { get; set; }
        public System.DateTime Gendate { get; set; }
        public System.DateTime DownFromGysDate { get; set; }
        public System.DateTime DownFromFescoDate { get; set; }
        public string Oper { get; set; }
    }
}
