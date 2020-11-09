using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Rpt_Gen_Note
    {
        public int Id { get; set; }
        public int Rptid { get; set; }
        public int Cyear { get; set; }
        public int Cmonth { get; set; }
        public int Cday { get; set; }
        public System.DateTime Gendate { get; set; }
    }
}
