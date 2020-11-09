using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_S_Log
    {
        public int ID { get; set; }
        public int SysUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int DoType { get; set; }
        public string DataSort { get; set; }
        public int DataId { get; set; }
        public string Result { get; set; }
    }
}
