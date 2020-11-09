using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Complaints
    {
        public int Id { get; set; }
        public int Danid { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Sort { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Back1 { get; set; }
        public string Back2 { get; set; }
        public System.DateTime Subtime1 { get; set; }
        public System.DateTime Subtime2 { get; set; }
        public System.DateTime Backtime1 { get; set; }
        public System.DateTime Backtime2 { get; set; }
        public int Isback { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Pic3 { get; set; }
        public string Pic4 { get; set; }
        public int Status { get; set; }
        public string Backusername1 { get; set; }
        public string Backusername2 { get; set; }
        public int Xuhao { get; set; }
        public long Hid { get; set; }
    }
}
