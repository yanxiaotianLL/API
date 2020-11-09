using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Pjigou
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InterFacePath { get; set; }
        public bool IsDelete { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int IsBackReport { get; set; }
    }
}
