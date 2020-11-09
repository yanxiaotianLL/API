using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string CreateAdmin { get; set; }
        public string UpdateAdmin { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> SortValue { get; set; }
    }
}
