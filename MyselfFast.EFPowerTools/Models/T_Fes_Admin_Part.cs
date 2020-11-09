using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Part
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string PartName { get; set; }
        public string Memo { get; set; }
        public int LevelIs { get; set; }
        public bool HasChildren { get; set; }
        public bool IsDelete { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
    }
}
