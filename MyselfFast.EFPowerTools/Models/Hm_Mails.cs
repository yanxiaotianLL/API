using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hm_Mails
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public System.DateTime Gendate { get; set; }
        public bool Readstate { get; set; }
        public bool State { get; set; }
    }
}
