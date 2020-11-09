using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class zp_userinfo
    {
        public int Id { get; set; }
        public string Openid { get; set; }
        public string Uname { get; set; }
        public System.DateTime Ubirthday { get; set; }
        public string Sex { get; set; }
        public string University { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set; }
        public string Cardid { get; set; }
        public string Email { get; set; }
        public string Internshiptime { get; set; }
        public string Internshipinfo { get; set; }
    }
}
