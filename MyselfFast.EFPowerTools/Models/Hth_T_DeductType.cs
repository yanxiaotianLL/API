using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_DeductType
    {
        public int ID { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public string Note { get; set; }
    }
}
