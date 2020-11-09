using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_BenefitsProductFileInfo
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string BJFileName { get; set; }
        public string BJFileUrl { get; set; }
        public int BJFileType { get; set; }
        public string WDFileName { get; set; }
        public string WDFileUrl { get; set; }
        public int WDFileType { get; set; }
    }
}
