using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_ProveRecord
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int OrderId { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int ProveFesId { get; set; }
        public string ProveFesName { get; set; }
    }
}
