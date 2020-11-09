using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Report_Item
    {
        public int ID { get; set; }
        public string ParentName { get; set; }
        public System.DateTime ConfirmTime { get; set; }
        public int ExmType { get; set; }
        public int ReportId { get; set; }
        public int busiCustId { get; set; }
        public string busiCustName { get; set; }
    }
}
