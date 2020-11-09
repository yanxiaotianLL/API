using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_FenType
    {
        public int Id { get; set; }
        public string FenType { get; set; }
        public string Miaoshu { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
        public int State { get; set; }
        public System.DateTime LmtTime { get; set; }
        public int Belongto { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public System.DateTime EditTime { get; set; }
    }
}
