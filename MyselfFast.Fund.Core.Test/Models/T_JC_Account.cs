using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_JC_Account
    {
        public int Id { get; set; }
        public string CON_ACCE_ID { get; set; }
        public string BUSI_CUST_NO { get; set; }
        public string Address_ID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int State { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> ActiveTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> IsEmailVerification { get; set; }
        public Nullable<bool> IsPhoneVerification { get; set; }
        public string UNIT_NO { get; set; }
        public string CONT_NO { get; set; }
    }
}
