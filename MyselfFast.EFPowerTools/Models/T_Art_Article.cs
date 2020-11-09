using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Art_Article
    {
        public int Id { get; set; }
        public int Colid { get; set; }
        public string Title { get; set; }
        public int Idx { get; set; }
        public System.DateTime Pubdate { get; set; }
        public string Source { get; set; }
        public string Author { get; set; }
        public int Arcst { get; set; }
        public string Content { get; set; }
        public long Hits { get; set; }
        public System.DateTime Hitstime { get; set; }
        public bool State { get; set; }
        public int TypeId { get; set; }
        public string ArtType { get; set; }
    }
}
