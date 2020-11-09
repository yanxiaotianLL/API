using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Benefit_Leave
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public string Cname { get; set; }
        public string Mark { get; set; }
        public string Leavetype { get; set; }
        public string Tel { get; set; }
        public string Title { get; set; }
        public string Leavecontent { get; set; }
        public string Back { get; set; }
        public System.DateTime Subtime { get; set; }
        public System.DateTime Backtime { get; set; }
        public bool Isdelete { get; set; }
        public int State { get; set; }
    }
}
