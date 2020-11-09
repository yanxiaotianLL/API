using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Role
    {
        public int Id { get; set; }
        public bool Flable { get; set; }
        public bool Fesable { get; set; }
        public bool Onsitable { get; set; }
        public bool Checkable { get; set; }
        public int Onsite_Create_On { get; set; }
        public bool Isdeleted { get; set; }
        public bool Midicalable { get; set; }
    }
}
