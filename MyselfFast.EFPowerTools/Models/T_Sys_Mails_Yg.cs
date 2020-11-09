using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Mails_Yg
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public System.DateTime Gendate { get; set; }
        public bool Readstate { get; set; }
        public bool State { get; set; }
        public int Fid { get; set; }
        public string Recontext { get; set; }
        public string Aid { get; set; }
        public System.DateTime Redate { get; set; }
        public int Fesid { get; set; }
    }
}
