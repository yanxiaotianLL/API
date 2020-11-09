using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_AssessmentResult
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public int OrderId { get; set; }
        public int PackageId { get; set; }
        public string Topic { get; set; }
        public string TestResult { get; set; }
        public string Remark { get; set; }
        public string Suggest { get; set; }
        public System.DateTime DoneTime { get; set; }
        public System.DateTime SubTime { get; set; }
    }
}
