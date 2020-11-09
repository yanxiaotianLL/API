using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_MenuData_RolePrivilege
    {
        public int RolePrivilegeID { get; set; }
        public int MenuDataID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateAdmin { get; set; }
        public Nullable<int> SortValue { get; set; }
        public int Id { get; set; }
    }
}
