using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Detail
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string FesName { get; set; }
        public int Hno { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int InductionType { get; set; }
        public int IsFirstLogin { get; set; }
        public int IndOrderId { get; set; }
        public int BusiDataId { get; set; }
        public int BusiCustId { get; set; }
        public string BusiCustName { get; set; }
        public string BusiDepName { get; set; }
        public int BusiDepId { get; set; }
        public string busiRepName { get; set; }
        public int IndTaskId { get; set; }
        public int SenCondition { get; set; }
    }
}
