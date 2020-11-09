using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Gds_PubTail_ext
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public long Idx { get; set; }
        public int Hid { get; set; }
        public System.DateTime Selectbyfescodate { get; set; }
        public int Gysid { get; set; }
        public string GysJiancheng { get; set; }
        public string Gysname { get; set; }
        public bool IsSendByGys { get; set; }
        public string Numbers { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string AliasName { get; set; }
        public string AliasEName { get; set; }
        public string Stand { get; set; }
        public string Model { get; set; }
        public string Product { get; set; }
        public string Ysname { get; set; }
        public string Ysname2 { get; set; }
        public long Mcid { get; set; }
        public string Mcname { get; set; }
        public string Jianj { get; set; }
        public string Content { get; set; }
        public bool Tuiable { get; set; }
        public string Attention { get; set; }
        public int State { get; set; }
        public long Hits { get; set; }
        public System.DateTime Hitstime { get; set; }
        public string Img { get; set; }
        public string Imgs { get; set; }
        public int Ys1 { get; set; }
        public string Ys1name { get; set; }
        public int Ys2 { get; set; }
        public string Ys2name { get; set; }
        public decimal Price { get; set; }
        public int Kucun { get; set; }
        public int Hiskucun { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
    }
}
