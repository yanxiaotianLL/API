using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Log
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public string Cname { get; set; }
        public System.DateTime Opertime { get; set; }
        public int Opertype { get; set; }
        public string Opername { get; set; }
        public string Beizu { get; set; }
    }
}
