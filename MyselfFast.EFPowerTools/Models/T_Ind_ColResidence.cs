using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_ColResidence
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int State { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int DetailId { get; set; }
    }
}
