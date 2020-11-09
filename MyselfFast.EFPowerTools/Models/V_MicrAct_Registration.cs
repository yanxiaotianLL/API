using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_MicrAct_Registration
    {
        public int ID { get; set; }
        public Nullable<int> ActiveID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> Pubtime { get; set; }
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
        public Nullable<int> Paystatus { get; set; }
        public Nullable<System.DateTime> Fenday { get; set; }
        public Nullable<int> Payway { get; set; }
        public Nullable<int> Personnum { get; set; }
        public Nullable<decimal> Totalpay { get; set; }
        public Nullable<decimal> Selfpay { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public string PayRemark { get; set; }
        public string Email { get; set; }
        public Nullable<int> IsRequireBill { get; set; }
        public string BillTitle { get; set; }
        public Nullable<int> GetBillWay { get; set; }
        public string BillSendAddress { get; set; }
        public string BillReceiveTel { get; set; }
        public Nullable<int> UserType { get; set; }
        public Nullable<int> ConfirmOrderStatus { get; set; }
        public string ConfirmOrderOperator { get; set; }
        public Nullable<System.DateTime> ConfirmOrderTime { get; set; }
        public string PromoCode { get; set; }
        public string BillContent { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> ApplyStatus { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<int> ParentActiveID { get; set; }
        public string JoinPerson { get; set; }
        public Nullable<int> AbDateID { get; set; }
        public Nullable<int> Benefittype { get; set; }
        public string Benefitname { get; set; }
        public int Hno { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Usedname { get; set; }
        public string Gno { get; set; }
        public string CardId { get; set; }
        public string Mobile { get; set; }
    }
}
