using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_OrderDetail
    {
        public int Id { get; set; }
        public int Sid { get; set; }
        public System.Guid ParentGuid { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string CardRule { get; set; }
        public string CardNo { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int BuyNum { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public System.DateTime SubTime { get; set; }
        public int ProjectId_Old { get; set; }
        public int PackageId_Old { get; set; }
        public string CardRule_Old { get; set; }
        public string CardNo_Old { get; set; }
        public int PSID { get; set; }
        public bool IsDelete { get; set; }
        public int TExmPkgItemId { get; set; }
        public int TExmPromId { get; set; }
        public decimal PriceSales { get; set; }
        public int IsUsePromoCode { get; set; }
        public decimal PriceRakeBack { get; set; }
        public decimal TtlSales { get; set; }
        public decimal TtlRakeBack { get; set; }
    }
}
