using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_ProveOrder
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string FesName { get; set; }
        public int Hno { get; set; }
        public int OrderType { get; set; }
        public int Status { get; set; }
        public System.DateTime CreatDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int ProveFesId { get; set; }
        public string ProveFesName { get; set; }
        public int proveState { get; set; }
        public int ServiceCenterId { get; set; }
        public string ServiceCenterName { get; set; }
    }
}
