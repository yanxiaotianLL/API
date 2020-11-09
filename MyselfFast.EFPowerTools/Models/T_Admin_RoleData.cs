using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Admin_RoleData
    {
        public int Id { get; set; }
        public string DataValue { get; set; }
        public string DataKey { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateAdmin { get; set; }
        public string Icon { get; set; }
        public Nullable<int> SortValue { get; set; }
    }
}
