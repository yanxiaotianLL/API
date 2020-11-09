using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_S_Pack
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int SysUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string OrderIds { get; set; }
        public string PNumber { get; set; }
        public Nullable<int> Operuser { get; set; }
    }
}
