using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Base_Ys2
    {
        public int Id { get; set; }
        public long Hid { get; set; }
        public int Pid { get; set; }
        public int Sid { get; set; }
        public string Name { get; set; }
        public decimal Costprice { get; set; }
        public decimal Basisprice { get; set; }
        public string Basisource { get; set; }
        public decimal Extprice { get; set; }
        public string Extsource { get; set; }
        public decimal Crossweight { get; set; }
        public decimal Realweight { get; set; }
        public int Kucun { get; set; }
        public int Assign { get; set; }
        public bool Isdelete { get; set; }
        public bool Isused { get; set; }
    }
}
