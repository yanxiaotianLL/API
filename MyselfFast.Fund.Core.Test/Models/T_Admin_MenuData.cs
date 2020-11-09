using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_MenuData
    {
        public int Id { get; set; }
        public int MenuID { get; set; }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string CreateAdmin { get; set; }
        public string UpdateAdmin { get; set; }
        public string Icon { get; set; }
        public Nullable<int> SortValue { get; set; }
    }
}
