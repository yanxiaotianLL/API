using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_OcrReason
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ImgId { get; set; }
        public int ImgType { get; set; }
        public string Message { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int Code { get; set; }
    }
}
