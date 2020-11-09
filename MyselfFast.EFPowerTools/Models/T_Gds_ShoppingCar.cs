using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_ShoppingCar
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public int PlanId { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public bool Fenable { get; set; }
        public bool Spread { get; set; }
        public int Hid { get; set; }
        public int Tid { get; set; }
        public string Hname { get; set; }
        public bool IsMonyOnly { get; set; }
        public int Ys1 { get; set; }
        public string Ys1Name { get; set; }
        public int Ys2 { get; set; }
        public string Ys2Name { get; set; }
        public decimal Weight { get; set; }
        public decimal RealWeight { get; set; }
        public decimal Price { get; set; }
        public decimal ExtPrice { get; set; }
        public int Nums { get; set; }
        public decimal Costprice { get; set; }
        public int Gysid { get; set; }
        public decimal Mprice { get; set; }
        public decimal Yprice { get; set; }
        public System.DateTime GenDate { get; set; }
        public string Thumbnail { get; set; }
        public bool IsYouhui { get; set; }
        public string Youhuicode { get; set; }
        public bool Locked { get; set; }
        public bool IsError { get; set; }
        public string ErrorMsg { get; set; }
        public string Ys1TypeName { get; set; }
        public string Ys2TypeName { get; set; }
        public decimal DUIPRICE { get; set; }
        public int Mtype { get; set; }
        public string Dealrule { get; set; }
    }
}
