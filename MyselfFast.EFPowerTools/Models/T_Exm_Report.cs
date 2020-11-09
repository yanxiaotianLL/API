using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Report
    {
        public int ID { get; set; }
        public int FesId { get; set; }
        public int FormalityID { get; set; }
        public int UID { get; set; }
        public int ReportState { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int ConfirmState { get; set; }
        public System.DateTime ConfirmTime { get; set; }
        public int DocID { get; set; }
        public string DocRemark { get; set; }
        public int ExmType { get; set; }
        public string T_Sys_FileId { get; set; }
        public string ExceptResult { get; set; }
        public int State { get; set; }
    }
}
