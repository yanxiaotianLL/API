using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Role
    {
        public int Id { get; set; }
        public string Rolename { get; set; }
        public string Rolescript { get; set; }
        public bool ClubAble { get; set; }
        public bool FlsAble { get; set; }
        public bool SupAble { get; set; }
        public bool IsDelete { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public bool IsGys { get; set; }
        public bool IsFls { get; set; }
        public bool IsExm { get; set; }
    }
}
