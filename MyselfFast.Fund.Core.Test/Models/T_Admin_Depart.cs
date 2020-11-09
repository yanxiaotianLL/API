using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Admin_Depart
    {
        public T_Admin_Depart()
        {
            this.T_Admin_Account = new List<T_Admin_Account>();
        }

        public int Id { get; set; }
        public string DepartName { get; set; }
        public string DepartDescription { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string CreateAdmin { get; set; }
        public string UpdateAdmin { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string DepartLeader { get; set; }
        public string LeaderEmail { get; set; }
        public Nullable<int> SortValue { get; set; }
        public string DepartCode { get; set; }
        public Nullable<bool> IsLeaf { get; set; }
        public virtual ICollection<T_Admin_Account> T_Admin_Account { get; set; }
    }
}
