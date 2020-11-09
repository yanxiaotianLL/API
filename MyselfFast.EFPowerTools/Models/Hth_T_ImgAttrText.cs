using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_ImgAttrText
    {
        public int ID { get; set; }
        public int ImgId { get; set; }
        public int AttrId { get; set; }
        public string Content { get; set; }
        public int State { get; set; }
    }
}
