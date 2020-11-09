using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Guide
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int IsInsurance { get; set; }
        public int DomicileType { get; set; }
        public int FilePlace { get; set; }
        public int IsChange { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    }
}
