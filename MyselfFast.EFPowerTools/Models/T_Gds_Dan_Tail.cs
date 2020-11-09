using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Tail
    {
        public int Id { get; set; }
        public int Parentid { get; set; }
        public int Orderid { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
        public int Hid { get; set; }
        public long oldhid { get; set; }
        public int Tid { get; set; }
        public string Hname { get; set; }
        public string AliasName { get; set; }
        public int Ys1 { get; set; }
        public string Ys1Name { get; set; }
        public int Ys2 { get; set; }
        public string Ys2Name { get; set; }
        public decimal Weight { get; set; }
        public decimal RealWeight { get; set; }
        public decimal Price { get; set; }
        public decimal ExtPrice { get; set; }
        public int Nums { get; set; }
        public int Tnums { get; set; }
        public int Sendstate { get; set; }
        public decimal Costprice { get; set; }
        public int Isgys { get; set; }
        public int Gysid { get; set; }
        public string GysName { get; set; }
        public decimal Mprice { get; set; }
        public decimal Yprice { get; set; }
        public bool IsYouhui { get; set; }
        public string Memo { get; set; }
        public string Thumbnail { get; set; }
        public string Ys1TypeName { get; set; }
        public string Ys2TypeName { get; set; }
        public bool State { get; set; }
        public decimal DUIPRICE { get; set; }
        public decimal Mnypay { get; set; }
        public decimal Fenpay { get; set; }
        public decimal Cardpay { get; set; }
        public decimal Decfei { get; set; }
        public decimal InterRate { get; set; }
        public int Mtype { get; set; }
        public string Dealrule { get; set; }
    }
}
