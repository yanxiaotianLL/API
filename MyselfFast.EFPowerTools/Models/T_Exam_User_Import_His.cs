using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exam_User_Import_His
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Gno { get; set; }
        public string Cname { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public int CardType { get; set; }
        public string CardName { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public System.DateTime ImportTime { get; set; }
        public bool IsInc { get; set; }
        public System.DateTime BakTime { get; set; }
    }
}
