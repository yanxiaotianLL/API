using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Scmsg_ChangebusDet
    {
        public int ID { get; set; }
        public int BusId { get; set; }
        public long OldNo { get; set; }
        public string OldContent { get; set; }
        public long NewNo { get; set; }
        public string NewContent { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
