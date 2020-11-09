using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Fls_Notice
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Title { get; set; }
        public System.DateTime Pubdate { get; set; }
        public string Content { get; set; }
        public string Lanmu { get; set; }
        public int Idx { get; set; }
        public bool State { get; set; }
        public int Hits { get; set; }
        public System.DateTime Hitstime { get; set; }
    }
}
