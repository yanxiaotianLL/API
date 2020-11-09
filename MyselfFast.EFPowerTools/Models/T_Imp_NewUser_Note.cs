using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Imp_NewUser_Note
    {
        public int Id { get; set; }
        public string Pc { get; set; }
        public int Fid { get; set; }
        public int Instype { get; set; }
        public int State { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
