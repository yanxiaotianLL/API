using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Que_Wake
    {
        public int Id { get; set; }
        public int Hid { get; set; }
        public string Cname { get; set; }
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int Ys1 { get; set; }
        public string Ys1name { get; set; }
        public int Ys2 { get; set; }
        public string Ys2name { get; set; }
        public int Kucun { get; set; }
    }
}
