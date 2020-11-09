using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public string Url { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> SortValue { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string CreateAdmin { get; set; }
        public string UpdateAdmin { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> IsDefault { get; set; }
        public string Icon { get; set; }
        public string MenuCode { get; set; }
        public bool IsLeaf { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
}
