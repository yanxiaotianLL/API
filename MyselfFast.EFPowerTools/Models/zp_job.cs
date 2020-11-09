using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class zp_job
    {
        public int Id { get; set; }
        public string Jname { get; set; }
        public string Jinfo { get; set; }
        public int Cid { get; set; }
        public int Jstu { get; set; }
        public System.DateTime Jdate { get; set; }
        public int Jnum { get; set; }
        public string jsalary { get; set; }
        public System.DateTime Endtime { get; set; }
        public int Checknum { get; set; }
    }
}
