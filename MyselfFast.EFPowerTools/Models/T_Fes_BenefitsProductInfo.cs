using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_BenefitsProductInfo
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool GroupFlag { get; set; }
        public string Remark { get; set; }
    }
}
