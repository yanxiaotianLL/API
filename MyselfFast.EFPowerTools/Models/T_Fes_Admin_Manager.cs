using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Manager
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RealName { get; set; }
        public string EName { get; set; }
        public string Script { get; set; }
        public string Pass { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsAdmin { get; set; }
        public int PageSize { get; set; }
        public string Lastip { get; set; }
        public System.DateTime Lastlogintime { get; set; }
        public int Visittimes { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public int StateLogin { get; set; }
        public Nullable<int> FlsArea { get; set; }
        public Nullable<int> BelongId { get; set; }
    }
}
