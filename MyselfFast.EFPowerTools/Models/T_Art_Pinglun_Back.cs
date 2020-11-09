using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Art_Pinglun_Back
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int Operid { get; set; }
        public string Oper { get; set; }
        public string Backs { get; set; }
        public System.DateTime Operdate { get; set; }
        public int State { get; set; }
    }
}
