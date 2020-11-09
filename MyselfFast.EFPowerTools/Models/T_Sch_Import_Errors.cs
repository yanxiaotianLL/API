using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_Import_Errors
    {
        public int Id { get; set; }
        public int Planid { get; set; }
        public int Fesid { get; set; }
        public string Usedname { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string ErrorText { get; set; }
    }
}
