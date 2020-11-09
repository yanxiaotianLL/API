using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_JC_Task
    {
        public T_JC_Task()
        {
            this.T_JC_DataItem = new List<T_JC_DataItem>();
            this.T_JC_File = new List<T_JC_File>();
        }

        public int Id { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int WageAccuracy { get; set; }
        public string CollectlType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }
        public string Address { get; set; }
        public string Address_ID { get; set; }
        public string Description { get; set; }
        public string OrderID { get; set; }
        public string ShiKaiRate { get; set; }
        public string NotShiKaiRate { get; set; }
        public int CollectProduct { get; set; }
        public int TaskType { get; set; }
        public virtual ICollection<T_JC_DataItem> T_JC_DataItem { get; set; }
        public virtual ICollection<T_JC_File> T_JC_File { get; set; }
    }
}
