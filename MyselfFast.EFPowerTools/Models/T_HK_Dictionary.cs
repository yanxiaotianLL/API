using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_HK_Dictionary
    {
        public int Id { get; set; }
        public string DictValue { get; set; }
        public string DictName { get; set; }
        public string KeyValue { get; set; }
        public string keyDesc { get; set; }
        public int Flag { get; set; }
        public int OrderNum { get; set; }
    }
}
