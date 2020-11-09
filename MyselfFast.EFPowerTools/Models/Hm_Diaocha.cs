using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hm_Diaocha
    {
        public long Id { get; set; }
        public int Idx { get; set; }
        public string Title { get; set; }
        public string Qst { get; set; }
        public int Hits { get; set; }
        public bool State { get; set; }
    }
}
