using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Check_Note
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int Checktype { get; set; }
        public string Checkname { get; set; }
        public string Memo { get; set; }
        public System.DateTime Gendate { get; set; }
        public int State { get; set; }
    }
}
