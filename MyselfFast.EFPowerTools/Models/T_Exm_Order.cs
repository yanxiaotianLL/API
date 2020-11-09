using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Order
    {
        public int Id { get; set; }
        public System.Guid TguId { get; set; }
        public int Fesid { get; set; }
        public decimal Pay { get; set; }
        public System.DateTime SubTime { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string OrderId { get; set; }
        public int PayType { get; set; }
        public System.DateTime PayTime { get; set; }
        public string PayMemo { get; set; }
        public bool IsPiao { get; set; }
        public System.DateTime PrintDate { get; set; }
        public string PiaoTitle { get; set; }
        public int PrintState { get; set; }
        public string SendNo { get; set; }
        public System.DateTime SendDate { get; set; }
        public int SendType { get; set; }
        public int ShouaddrId { get; set; }
        public string Shouaddr { get; set; }
        public string ShouaddrSimple { get; set; }
        public string ShouaddrTag { get; set; }
        public string PiaoContent { get; set; }
        public string ShouMan { get; set; }
        public string ShouTel { get; set; }
        public string ShouPost { get; set; }
        public int IsMailed { get; set; }
        public System.DateTime BackDate { get; set; }
        public string DackMemo { get; set; }
        public System.DateTime TuiDate { get; set; }
        public int TuiStatus { get; set; }
        public int Fid { get; set; }
        public int Id_order { get; set; }
        public bool IsBag { get; set; }
        public int CheckType { get; set; }
        public bool IsUpgrade { get; set; }
        public bool HasRealCard { get; set; }
        public int PSID { get; set; }
        public string POrderNo { get; set; }
        public bool HasSubs { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime FinDate { get; set; }
        public string Alipayno { get; set; }
        public string Adminname { get; set; }
        public int Adminid { get; set; }
        public System.DateTime Lastdate { get; set; }
        public string KdCompany { get; set; }
        public int CostType { get; set; }
        public string PiaoFname { get; set; }
        public string PiaoNumber { get; set; }
        public int PiaoType { get; set; }
        public int IsUsePromoCode { get; set; }
        public decimal TtlSales { get; set; }
        public decimal TtlRakeBack { get; set; }
        public string DataFrom { get; set; }
        public int PromoCode { get; set; }
    }
}
