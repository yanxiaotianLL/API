using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_ZP_Perappjob
    {
        public int Id { get; set; }
        public int Jid { get; set; }
        public System.DateTime Pdate { get; set; }
        public int Uid { get; set; }
        public int Comid { get; set; }
        public string Jobname { get; set; }
        public string Letterinfo { get; set; }
    }
}
