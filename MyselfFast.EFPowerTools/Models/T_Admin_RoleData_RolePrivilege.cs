using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Admin_RoleData_RolePrivilege
    {
        public int Id { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> RoleDataID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateAdmin { get; set; }
    }
}
