using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_JC_File
    {
        public int Id { get; set; }
        public string FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string FileType { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public virtual T_JC_Task T_JC_Task { get; set; }
    }
}
