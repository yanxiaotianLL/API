using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Order
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public int CostSort { get; set; }
        public int HosId { get; set; }
        public System.DateTime SeeDateBin { get; set; }
        public System.DateTime SeeTimeEnd { get; set; }
        public string DiseaseName { get; set; }
        public double SelfApplyAmount { get; set; }
        public double Proportion { get; set; }
        public double RealAmount { get; set; }
        public int ForPersonType { get; set; }
        public int Fesid { get; set; }
        public int Position { get; set; }
        public string HisPosition { get; set; }
        public int Settlement { get; set; }
        public string SPosition { get; set; }
        public string AuDiseaseName { get; set; }
        public int State { get; set; }
        public double SelfPay { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Note { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string OType { get; set; }
        public int OTypeId { get; set; }
        public int UpdateBy { get; set; }
        public string ProdScheId { get; set; }
        public string XOrderId { get; set; }
        public string XOrderItemId { get; set; }
        public string billno { get; set; }
        public Nullable<System.DateTime> SubTime { get; set; }
        public int TState { get; set; }
        public string Email { get; set; }
        public long ProdId { get; set; }
        public long ProdPriceId { get; set; }
        public string ProdPriceName { get; set; }
        public int IsPrint { get; set; }
        public int IsPause { get; set; }
        public int IsBeiJing { get; set; }
        public string PackNumber { get; set; }
        public string OcrSign { get; set; }
        public Nullable<int> EntityAdminId { get; set; }
        public Nullable<double> Sedates { get; set; }
        public Nullable<decimal> hthDeductAmount { get; set; }
        public Nullable<int> IsCallSuccess { get; set; }
        public string Hospital { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string PositionNew { get; set; }
        public string EntityErrorMsg { get; set; }
        public int DataSource { get; set; }
    }
}
