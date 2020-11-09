using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_S_SetAudit
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public int SysUserId { get; set; }
        public int AuType { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public Nullable<int> OperState { get; set; }
    }
}
