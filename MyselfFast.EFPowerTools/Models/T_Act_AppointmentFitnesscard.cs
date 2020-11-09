using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_AppointmentFitnesscard
    {
        public int Id { get; set; }
        public int Appid { get; set; }
        public string Company { get; set; }
        public System.DateTime Ftime { get; set; }
        public int fstu { get; set; }
        public int Fesid { get; set; }
    }
}
