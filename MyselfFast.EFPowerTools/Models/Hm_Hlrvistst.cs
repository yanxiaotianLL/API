using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hm_Hlrvistst
    {
        public int Id { get; set; }
        public string Visistname { get; set; }
        public string Pass { get; set; }
        public string Thispasscode { get; set; }
        public System.DateTime Gendate { get; set; }
    }
}
