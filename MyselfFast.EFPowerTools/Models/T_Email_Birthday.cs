using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Email_Birthday
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int Eid { get; set; }
        public int State { get; set; }
        public int BeforeDay { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public System.DateTime LastExecutionDate { get; set; }
    }
}
