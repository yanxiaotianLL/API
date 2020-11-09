using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Formality
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string FesName { get; set; }
        public int Hno { get; set; }
        public int FormalityType { get; set; }
        public string FormalityName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }
        public int FormalityLevel { get; set; }
        public int FormalityOrder { get; set; }
        public string FormalityUrl { get; set; }
        public int FatherId { get; set; }
        public int FormalityStep { get; set; }
        public int IndDetailId { get; set; }
        public int FlowID { get; set; }
        public string FailReason { get; set; }
        public int StepOrder { get; set; }
        public string FormlityPreviewUrl { get; set; }
        public int IsDelete { get; set; }
        public int SourceType { get; set; }
        public string BusiRepName { get; set; }
        public int IndTaskId { get; set; }
        public int SenCondition { get; set; }
        public string FormalityTypeName { get; set; }
        public int IsSynchro { get; set; }
    }
}
