using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_HK_TaskDetail
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public int Approveempid { get; set; }
        public System.DateTime Opertime { get; set; }
        public int Workflowid { get; set; }
        public string Remarks { get; set; }
    }
}
