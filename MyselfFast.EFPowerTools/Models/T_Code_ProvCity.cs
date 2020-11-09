using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Code_ProvCity
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public int Pid { get; set; }
        public int Area { get; set; }
        public bool Show { get; set; }
        public int Jdid { get; set; }
    }
}
