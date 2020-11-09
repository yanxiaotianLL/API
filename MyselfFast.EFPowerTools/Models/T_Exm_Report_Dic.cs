using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Report_Dic
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public int ParentId { get; set; }
        public string UnitName { get; set; }
        public string ParentName { get; set; }
    }
}
