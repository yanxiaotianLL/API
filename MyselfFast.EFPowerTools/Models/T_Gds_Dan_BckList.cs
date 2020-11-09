using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_BckList
    {
        public int Id { get; set; }
        public int Parentid { get; set; }
        public int Orderid { get; set; }
        public string Parentno { get; set; }
        public string Orderno { get; set; }
        public string QryParentno { get; set; }
        public int Tailid { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public string Usedname { get; set; }
        public string Cname { get; set; }
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public int Tid { get; set; }
        public string Hname { get; set; }
        public string AliasName { get; set; }
        public string Ys1TypeName { get; set; }
        public int Ys1 { get; set; }
        public string Ys1Name { get; set; }
        public string Ys2TypeName { get; set; }
        public int Ys2 { get; set; }
        public string Ys2Name { get; set; }
        public int Nums { get; set; }
        public int Tnums { get; set; }
        public decimal BackMnypay { get; set; }
        public decimal BackFenpay { get; set; }
        public decimal BackCardpay { get; set; }
        public string Memo { get; set; }
        public System.DateTime GenDate { get; set; }
        public int Oper { get; set; }
        public string Opername { get; set; }
    }
}
