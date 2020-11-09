using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ben_MyfamilyInformation
    {
        public int ID { get; set; }
        public int FesID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public System.DateTime Birthday { get; set; }
        public string HouseholdRegister { get; set; }
        public string LiveAddress { get; set; }
        public string CertificateCode { get; set; }
        public string PoliticalStatus { get; set; }
        public string HouseholeType { get; set; }
        public string RelationShip { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime LastModifyTime { get; set; }
        public int Sex { get; set; }
        public int CertificateType { get; set; }
        public string Bankcardname { get; set; }
        public string Banktype { get; set; }
        public string Bankcardno { get; set; }
    }
}
