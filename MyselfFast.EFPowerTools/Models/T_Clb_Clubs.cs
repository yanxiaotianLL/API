using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Clb_Clubs
    {
        public int Id { get; set; }
        public int Ctype { get; set; }
        public string Cname { get; set; }
        public string Cusername { get; set; }
        public string Cuserpwd { get; set; }
        public string Ccode { get; set; }
        public string Caddress { get; set; }
        public string Cpost { get; set; }
        public string Ccontact { get; set; }
        public string Ctel { get; set; }
        public string Cphone { get; set; }
        public string Cfax { get; set; }
        public string Cemail { get; set; }
        public string Cqq { get; set; }
        public string Cmsn { get; set; }
        public System.DateTime Logtime { get; set; }
        public string Logip { get; set; }
        public bool Isdelete { get; set; }
        public string Logimg { get; set; }
        public bool Isshow { get; set; }
        public int Discuzid { get; set; }
        public bool Isdiscuz { get; set; }
        public bool Islink { get; set; }
        public string Link { get; set; }
        public int Disid { get; set; }
    }
}
