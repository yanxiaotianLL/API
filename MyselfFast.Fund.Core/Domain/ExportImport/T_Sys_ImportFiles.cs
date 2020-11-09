using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace myselfFast.Fund.Core.Domain.ExportImport
{
    [Serializable]
    public partial class T_Sys_ImportFiles : BaseEntity
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FileNameOld { get; set; }
        public string FileNameNew { get; set; }
        public string Path { get; set; }
        public int State { get; set; }
        public string Message { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string ParaJson { get; set; }
    }
}
