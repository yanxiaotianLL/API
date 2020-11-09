using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Admin_Account
    {
        public int Id { get; set; }
        public int DepartID { get; set; }
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string DepartName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string CreateAdmin { get; set; }
        public string UpdateAdmin { get; set; }
    }
}
