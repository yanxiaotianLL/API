using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Mdc_Medicaluserinfo
    {
        public int Id { get; set; }
        public int IsMedical { get; set; }
        public string Utype { get; set; }
        public int Fid { get; set; }
        public string Fname { get; set; }
        public string Fesid { get; set; }
        public int Hno { get; set; }
        public string Cname { get; set; }
        public string Gbumen { get; set; }
        public string Cid { get; set; }
        public string Sex { get; set; }
        public System.DateTime Birthday { get; set; }
        public string PeiCname { get; set; }
        public string PeiCid { get; set; }
        public string PeiSex { get; set; }
        public System.DateTime PeiBirthday { get; set; }
        public string SCname { get; set; }
        public string SCid { get; set; }
        public string SSex { get; set; }
        public System.DateTime SBirthday { get; set; }
        public System.DateTime Fulidate { get; set; }
        public int KaihuhangId { get; set; }
        public int Bxtype { get; set; }
        public string Bankcount { get; set; }
        public string Obaoxiao { get; set; }
        public string Pbaoxiao { get; set; }
        public string Zbaoxiao { get; set; }
        public System.DateTime Updatetime { get; set; }
        public string Operuser { get; set; }
        public string SX { get; set; }
        public string DX { get; set; }
    }
}
