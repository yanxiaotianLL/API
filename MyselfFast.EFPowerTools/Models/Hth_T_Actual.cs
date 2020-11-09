using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Actual
    {
        public int ID { get; set; }
        public string OrderIds { get; set; }
        public int AType { get; set; }
        public string SendCom { get; set; }
        public string SendNO { get; set; }
        public string Phone { get; set; }
        public int TType { get; set; }
        public int TPosition { get; set; }
        public string TAdress { get; set; }
        public string TCom { get; set; }
        public string TNO { get; set; }
        public string TPhone { get; set; }
        public string Tname { get; set; }
        public string TCode { get; set; }
        public int Fen { get; set; }
        public int FType { get; set; }
        public int FPosition { get; set; }
        public string FAdress { get; set; }
        public string FCom { get; set; }
        public string FNO { get; set; }
        public string FPhone { get; set; }
        public string Fname { get; set; }
        public string FCode { get; set; }
        public string CreateSign { get; set; }
        public string Email { get; set; }
        public bool IsSend { get; set; }
        public Nullable<int> OrderWrapID { get; set; }
    }
}
