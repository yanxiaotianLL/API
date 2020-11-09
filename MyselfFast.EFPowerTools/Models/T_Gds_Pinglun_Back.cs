using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Pinglun_Back
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int Operid { get; set; }
        public string OperName { get; set; }
        public string Asks { get; set; }
        public System.DateTime Backdate { get; set; }
        public int State { get; set; }
    }
}
