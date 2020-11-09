using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Registration
    {
        public int ID { get; set; }
        public int ActiveID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public System.DateTime Pubtime { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }
        public string Input3 { get; set; }
        public string Input4 { get; set; }
        public string Input5 { get; set; }
        public string Input6 { get; set; }
        public string Input7 { get; set; }
        public string Input8 { get; set; }
        public string Input9 { get; set; }
        public string Input10 { get; set; }
        public string Input11 { get; set; }
        public string Input12 { get; set; }
        public string Input13 { get; set; }
        public string Input14 { get; set; }
        public string Input15 { get; set; }
        public string Input16 { get; set; }
        public string Input17 { get; set; }
        public string Input18 { get; set; }
        public string Input19 { get; set; }
        public string Input20 { get; set; }
        public string Gdsnum { get; set; }
        public int Paystatus { get; set; }
        public System.DateTime Fenday { get; set; }
        public int Payway { get; set; }
        public int Personnum { get; set; }
        public decimal Totalpay { get; set; }
        public decimal Selfpay { get; set; }
        public System.DateTime OrderTime { get; set; }
        public System.DateTime PayTime { get; set; }
        public string PayRemark { get; set; }
        public string Email { get; set; }
        public int IsRequireBill { get; set; }
        public string BillTitle { get; set; }
        public int GetBillWay { get; set; }
        public string BillSendAddress { get; set; }
        public string BillReceiveTel { get; set; }
        public int UserType { get; set; }
        public int ConfirmOrderStatus { get; set; }
        public string ConfirmOrderOperator { get; set; }
        public System.DateTime ConfirmOrderTime { get; set; }
        public string PromoCode { get; set; }
        public string BillContent { get; set; }
        public int IsDelete { get; set; }
        public int ApplyStatus { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public int ParentActiveID { get; set; }
        public string JoinPerson { get; set; }
        public int AbDateID { get; set; }
        public string BillReceiver { get; set; }
        public int BenefitType { get; set; }
        public string BenefitName { get; set; }
        public int SignUpType { get; set; }
        public int CardID { get; set; }
        public int ActiveFrom { get; set; }
        public int PiaoType { get; set; }
        public string PiaoNumber { get; set; }
    }
}
