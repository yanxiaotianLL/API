using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Project_Users
    {
        public int Projectid { get; set; }
        public int Fid { get; set; }
        public string Cname { get; set; }
        public string Cardno { get; set; }
        public int Fesid { get; set; }
        public bool State { get; set; }
        public bool Iscard { get; set; }
        public int Id { get; set; }
    }
}
