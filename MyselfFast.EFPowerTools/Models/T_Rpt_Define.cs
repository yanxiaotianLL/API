using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Rpt_Define
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkTable { get; set; }
        public string LinkProc { get; set; }
        public int GenType { get; set; }
        public bool State { get; set; }
        public int RolType { get; set; }
        public int OperType { get; set; }
    }
}
