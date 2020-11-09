using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_FundBussinessName
    {
        public int Id { get; set; }
        public string UNIT_NO { get; set; }
        public string UNIT_NAME_PRINT { get; set; }
        public string BUSI_CUST_NO { get; set; }
        public string BUSI_CUST_NAME { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string OptAccount { get; set; }
    }
}
