using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_OrderData
    {
        public int ID { get; set; }
        public Nullable<long> DoUserDeptId { get; set; }
        public string DoUserDept { get; set; }
        public int DoUserCom1 { get; set; }
        public int DoUserCom2 { get; set; }
        public int DoUserCom3 { get; set; }
        public int DoUserCom4 { get; set; }
        public string CradNo { get; set; }
        public string SpouseHno { get; set; }
        public string SpouseName { get; set; }
        public string SpouseDept { get; set; }
        public string RealName { get; set; }
        public long BankTypeId { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public int Sex { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> YId { get; set; }
        public Nullable<int> KId { get; set; }
        public Nullable<int> SYId { get; set; }
        public Nullable<int> SKId { get; set; }
        public Nullable<double> MZProportion { get; set; }
        public Nullable<double> SZProportion { get; set; }
        public Nullable<long> CYId { get; set; }
        public long BankId { get; set; }
        public string Email { get; set; }
        public bool IsSendE { get; set; }
        public int IsPart { get; set; }
    }
}
