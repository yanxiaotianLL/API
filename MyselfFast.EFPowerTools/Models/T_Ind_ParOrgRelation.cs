using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_ParOrgRelation
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public System.DateTime PartyTime { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int DetailId { get; set; }
    }
}
