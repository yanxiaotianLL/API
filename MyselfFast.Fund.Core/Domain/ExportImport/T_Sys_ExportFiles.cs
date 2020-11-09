using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.ExportImport
{
    [Serializable]
    public partial class T_Sys_ExportFiles : BaseEntity
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Path { get; set; }
        public int State { get; set; }
        public string Message { get; set; }
        public string ParmsJson { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime OutsTime { get; set; }
        public int IsDelete { get; set; }
        public string FileName { get; set; }
    }
}
