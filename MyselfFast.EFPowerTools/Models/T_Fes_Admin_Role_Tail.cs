using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Role_Tail
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public System.Guid Guid { get; set; }
        public bool EditAble { get; set; }
        public bool AuditAble { get; set; }
        public bool DelAble { get; set; }
    }
}
