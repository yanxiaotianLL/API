using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_ImgAttr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ImgSort { get; set; }
        public int State { get; set; }
        public int IType { get; set; }
        public int Calculate { get; set; }
        public int AttrSort { get; set; }
        public int OderType { get; set; }
        public string Flag { get; set; }
        public string ApiName { get; set; }
    }
}
