using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Tuan_Ins
    {
        public int Id { get; set; }
        public int Timeid { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int IdCardType { get; set; }
        public string IdCardNo { get; set; }
        public System.DateTime BirthDay { get; set; }
        public bool IsMarry { get; set; }
        public string Tel { get; set; }
        public string Comperny { get; set; }
        public int PakegeId { get; set; }
        public string HthCardNo { get; set; }
        public string HthCardPassWord { get; set; }
        public string PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonidType { get; set; }
        public string PersonSex { get; set; }
        public System.DateTime PersonBirthday { get; set; }
        public string PersonMerry { get; set; }
        public string PersonMobile { get; set; }
        public string PersonComp { get; set; }
    }
}
