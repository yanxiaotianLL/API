using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public string Meaning { get; set; }
        public decimal PriceMarket { get; set; }
        public decimal PriceSales { get; set; }
        public string Sex { get; set; }
        public string Marry { get; set; }
        public string ClassName { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime OperateTime { get; set; }
        public int OrderBy { get; set; }
        public string Name { get; set; }
        public decimal PriceEmployee { get; set; }
        public string Tag { get; set; }
    }
}
