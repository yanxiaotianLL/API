using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_RolePrivilege
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public int MenuID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateAdmin { get; set; }
    }
}
