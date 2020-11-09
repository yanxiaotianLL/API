using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Audit
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public int Sourid { get; set; }
        public int AuditNum { get; set; }
        public int AuditType { get; set; }
        public string Audit { get; set; }
        public string AuditInfo { get; set; }
        public int Operid { get; set; }
        public string Oper { get; set; }
        public System.DateTime Opertime { get; set; }
    }
}
