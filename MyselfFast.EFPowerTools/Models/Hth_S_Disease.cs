using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_S_Disease
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string SysUser { get; set; }
        public int State { get; set; }
        public string Pinyin { get; set; }
    }
}
