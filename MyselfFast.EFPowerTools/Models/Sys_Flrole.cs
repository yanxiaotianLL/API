using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Sys_Flrole
    {
        public long Id { get; set; }
        public int Fid { get; set; }
        public string Rolename { get; set; }
        public string Rolescript { get; set; }
        public bool Ishide { get; set; }
    }
}
