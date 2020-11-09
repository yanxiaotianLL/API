using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Onl_Tmp
    {
        public int Id { get; set; }
        public int MTmpId { get; set; }
        public string Classify { get; set; }
        public string Content { get; set; }
        public string Temp { get; set; }
    }
}
