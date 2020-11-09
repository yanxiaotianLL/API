using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_OneceCard
    {
        public int Id { get; set; }
        public int Planid { get; set; }
        public string Cardnum { get; set; }
        public string Cardpass { get; set; }
        public int Cardstatus { get; set; }
        public int Tiqian { get; set; }
        public System.DateTime Senddate { get; set; }
        public int Sendtype { get; set; }
        public string Email { get; set; }
        public bool Ismailed { get; set; }
        public string Cname { get; set; }
        public string Company { get; set; }
        public string Mobile { get; set; }
        public string Yewubu { get; set; }
        public string Yewubuuser { get; set; }
        public System.DateTime Birthday { get; set; }
        public int Microsoftid { get; set; }
    }
}
