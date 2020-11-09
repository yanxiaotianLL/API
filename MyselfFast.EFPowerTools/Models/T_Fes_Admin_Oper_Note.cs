using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Oper_Note
    {
        public int Id { get; set; }
        public int Operkey { get; set; }
        public int Daykey { get; set; }
        public int Operid { get; set; }
        public string Opername { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperType { get; set; }
        public string Oper { get; set; }
        public string Memo { get; set; }
    }
}
