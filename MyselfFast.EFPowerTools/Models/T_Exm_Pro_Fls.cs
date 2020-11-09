using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Pro_Fls
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int ProId { get; set; }
        public decimal PriceMarket { get; set; }
        public decimal PriceSales { get; set; }
        public decimal PriceEmployee { get; set; }
        public int IsCurrentUse { get; set; }
        public System.DateTime OperateTime { get; set; }
        public decimal PricePromoCode { get; set; }
        public int IsUsePromoCode { get; set; }
        public decimal PriceRakeBack { get; set; }
        public string ProjectPrompt { get; set; }
    }
}
