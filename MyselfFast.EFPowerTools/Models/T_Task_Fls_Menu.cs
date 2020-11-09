using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_Fls_Menu
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int ParentId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int Idx { get; set; }
        public string MenuText { get; set; }
        public int UrlType { get; set; }
        public string Url { get; set; }
        public string Context { get; set; }
        public string Target { get; set; }
        public int OldId { get; set; }
    }
}
