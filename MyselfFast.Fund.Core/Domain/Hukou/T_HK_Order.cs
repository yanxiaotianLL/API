using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Hukou
{
    [Serializable]
    public partial class T_HK_Order : BaseEntity
    {
        public int Id { get; set; }
        public string Uniqueno { get; set; }
        public int Fesid { get; set; }
        public int BussinessId { get; set; }
        public string BussinessName { get; set; }
        public string OrderNo { get; set; }
        public System.DateTime OrderTime { get; set; }
        public decimal OrderAmount { get; set; }
        public int AddrId { get; set; }
        public string AddrStr { get; set; }
        public string AddrStrTag { get; set; }
        public int Transtype { get; set; }
        public System.DateTime Committime { get; set; }
        public string TradeNo { get; set; }
        public int TradeMehtod { get; set; }
        public System.DateTime TradeTime { get; set; }
        public string SellerAccount { get; set; }
        public string BuyerAccount { get; set; }
        public string Updater { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int State { get; set; }
        public string Statename { get; set; }
        public int PiaoState { get; set; }
        public string PiaoTitle { get; set; }
        public string PiaoUse { get; set; }
        public bool PrintState { get; set; }
        public System.DateTime PrintDate { get; set; }
        public string Kno { get; set; }
        public string KName { get; set; }
        public string TradeName { get; set; }
        public string Pone { get; set; }
        public string Letterpeople { get; set; }
        public string Backcause { get; set; }
        public string Cancelcause { get; set; }
        public System.DateTime EndLendTime { get; set; }
        public int Frequency { get; set; }
        public string IsBackYajin { get; set; }
        public string BKno { get; set; }
        public string BKName { get; set; }
        public decimal OrderDeposit { get; set; }
        public System.DateTime OneTime { get; set; }
        public System.DateTime TwoTime { get; set; }
        public System.DateTime BackTime { get; set; }
        public string ShouMan { get; set; }
        public string Postcode { get; set; }
        public string Tel { get; set; }
        public string Adress { get; set; }
        public string Alipayno { get; set; }
        public string Backno { get; set; }
        public string Email { get; set; }
        public System.DateTime Expressbacktime { get; set; }
        public System.DateTime Threetime { get; set; }
        public int ReceiveMehtod { get; set; }
        public string Receivename { get; set; }
        public string PiaoNumber { get; set; }
        public int IsApplyMoney { get; set; }
        public string UserAlipayNo { get; set; }
        public string UserTel { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public string OrderFrom { get; set; }
        public int TradeStatus { get; set; }
        public int BackMoneyPic { get; set; }
        public int BKDOperId { get; set; }
        public int BYJOperId { get; set; }
        public int OrderRelevance { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public int IsSendEmail { get; set; }
    }
}
