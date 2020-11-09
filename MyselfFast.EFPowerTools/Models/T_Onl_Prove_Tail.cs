using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Onl_Prove_Tail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Mtypeid { get; set; }
        public string Mtypename { get; set; }
        public int Typeid { get; set; }
        public string Typename { get; set; }
        public int Usedid { get; set; }
        public string Usedname { get; set; }
        public string Timeslot { get; set; }
        public int ISReflect { get; set; }
    }
}
