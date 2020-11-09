using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Fennote_ins
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int Fentype { get; set; }
        public string Fno { get; set; }
        public string Pc { get; set; }
        public int State { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public bool IsCommit { get; set; }
    }
}
