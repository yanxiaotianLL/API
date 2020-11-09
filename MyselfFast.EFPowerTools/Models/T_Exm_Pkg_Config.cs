using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Pkg_Config
    {
        public decimal Id { get; set; }
        public string Config { get; set; }
        public int ParentId { get; set; }
        public int PackageId { get; set; }
    }
}
