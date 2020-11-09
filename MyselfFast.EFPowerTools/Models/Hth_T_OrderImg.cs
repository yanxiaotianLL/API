using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_OrderImg
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public string Img { get; set; }
        public string ImgNo { get; set; }
        public int ImgSort { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Note { get; set; }
        public double SAmount { get; set; }
        public double YAmount { get; set; }
        public double BAmount { get; set; }
        public double HAmount { get; set; }
        public double RAmount { get; set; }
        public string ImgAddress { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> Settlement { get; set; }
        public string RealName { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> IsPs { get; set; }
    }
}
