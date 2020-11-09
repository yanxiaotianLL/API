using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_JC_TaskUnit
    {
        public int Id { get; set; }
        public string CON_ACCE_ID { get; set; }
        public string BUSI_CUST_NO { get; set; }
        public string UNIT_NO { get; set; }
        public string Address_ID { get; set; }
        public string Address { get; set; }
        public Nullable<int> AccountID { get; set; }
        public string AccountName { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> State { get; set; }
        public string CONT_NO { get; set; }
        public string ACCE_NO { get; set; }
        public string SUPP_NO { get; set; }
        public Nullable<bool> IsNeedCollectTable { get; set; }
        public Nullable<bool> IsNeedAuditing { get; set; }
        public Nullable<int> AuditingState { get; set; }
        public string AuditingAccountName { get; set; }
        public Nullable<int> AuditingAccountID { get; set; }
        public string CollectionTableNo { get; set; }
        public string CollectlType { get; set; }
        public int CollectlProduct { get; set; }
        public string ShiKaiRate { get; set; }
        public string NotShiKaiRate { get; set; }
        public string SheBaoCapValue { get; set; }
        public string GongJiJinCapValue { get; set; }
    }
}
