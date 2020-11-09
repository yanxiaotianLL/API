using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hm_Mails_Yg_Re
    {
        public int Id { get; set; }
        public int Ymid { get; set; }
        public string Uid { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public System.DateTime Gendate { get; set; }
        public bool Readstate { get; set; }
        public bool State { get; set; }
        public int Fid { get; set; }
    }
}
