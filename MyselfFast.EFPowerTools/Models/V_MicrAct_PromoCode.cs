using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_MicrAct_PromoCode
    {
        public int ID { get; set; }
        public Nullable<int> ActiveID { get; set; }
        public Nullable<int> RegistrationID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string PromoCode { get; set; }
        public Nullable<int> UseStatus { get; set; }
        public Nullable<System.DateTime> IssuedTime { get; set; }
        public Nullable<decimal> Val { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public int Hno { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Usedname { get; set; }
        public string Gno { get; set; }
        public string CardId { get; set; }
        public string Mobile { get; set; }
    }
}
