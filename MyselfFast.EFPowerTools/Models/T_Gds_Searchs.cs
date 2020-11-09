using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Searchs
    {
        public int Id { get; set; }
        public string Findstr { get; set; }
        public int Hits { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
