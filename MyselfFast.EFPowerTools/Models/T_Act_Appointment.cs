using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Appointment
    {
        public int Id { get; set; }
        public int Userkey { get; set; }
        public int Fesid { get; set; }
        public string Username { get; set; }
        public string Usercname { get; set; }
        public string Orderid { get; set; }
        public string Sort { get; set; }
        public System.DateTime Apptime { get; set; }
        public string Timezone { get; set; }
        public string Content { get; set; }
        public System.DateTime Pubtime { get; set; }
        public int Status { get; set; }
        public int Donestatus { get; set; }
        public string Dept { get; set; }
    }
}
