using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_AppointmentProject
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public decimal Price { get; set; }
        public int Pstu { get; set; }
        public System.DateTime Ptime { get; set; }
        public string Pindicatir { get; set; }
        public int Pnum { get; set; }
        public string Appname { get; set; }
        public System.DateTime subtime { get; set; }
        public int Fesid { get; set; }
    }
}
