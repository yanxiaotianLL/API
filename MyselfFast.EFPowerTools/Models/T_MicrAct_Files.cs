using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Files
    {
        public int ID { get; set; }
        public Nullable<int> ActiveID { get; set; }
        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> FileType { get; set; }
        public string PositonMark { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}
