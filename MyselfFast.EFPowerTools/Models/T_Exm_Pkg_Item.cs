using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Pkg_Item
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int ItemId { get; set; }
        public decimal PriceMarket { get; set; }
        public decimal PriceSales { get; set; }
        public decimal PriceEmployee { get; set; }
        public int IsCurrentUse { get; set; }
        public int ItemType { get; set; }
    }
}
