using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_ZP_Company
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Logoimg { get; set; }
        public string Adminid { get; set; }
        public int Aid { get; set; }
        public int Gtadd { get; set; }
        public int Stu { get; set; }
        public string ZP_DisareaId { get; set; }
        public bool Isdelete { get; set; }
    }
}
