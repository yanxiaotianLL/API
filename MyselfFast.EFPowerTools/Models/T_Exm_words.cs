using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_words
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Fid { get; set; }
        public int Year { get; set; }
        public string Word { get; set; }
        public int Sort { get; set; }
        public int OrderNo { get; set; }
        public string MapPing { get; set; }
    }
}
