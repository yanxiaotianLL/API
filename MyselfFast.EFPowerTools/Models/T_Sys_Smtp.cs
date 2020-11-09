using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Smtp
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string Fip { get; set; }
    }
}
