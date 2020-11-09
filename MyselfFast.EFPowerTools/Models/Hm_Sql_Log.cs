using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hm_Sql_Log
    {
        public int Id { get; set; }
        public string Otype { get; set; }
        public long Oid { get; set; }
        public string Oname { get; set; }
        public System.DateTime Gendate { get; set; }
        public string Sqltext { get; set; }
        public string Paratext { get; set; }
        public string Error { get; set; }
    }
}
