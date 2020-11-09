using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Prom
    {
        public int Id { get; set; }
        public int ProId { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
