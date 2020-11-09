using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Power_ins
    {
        public int ID { get; set; }
        public int Fid { get; set; }
        public int PowerType { get; set; }
        public int Optype { get; set; }
        public string Pc { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
