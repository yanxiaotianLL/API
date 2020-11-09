using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Audit_Order
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public string Content { get; set; }
        public int AuUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int State { get; set; }
        public int AuUserType { get; set; }
        public int AuState { get; set; }
        public int AuType { get; set; }
        public string Memo { get; set; }
    }
}
