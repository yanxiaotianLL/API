using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Tb_dictionarylistTemp
    {
        public int id { get; set; }
        public string dcode { get; set; }
        public string dname_en { get; set; }
        public string dname { get; set; }
        public int dtype { get; set; }
        public string dcodeNew { get; set; }
        public string dnameNew { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
