using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Onl_IFInfo
    {
        public int Id { get; set; }
        public int Danid { get; set; }
        public string UserName { get; set; }
        public string UserSex { get; set; }
        public System.DateTime UserBirth { get; set; }
        public string UserNation { get; set; }
        public string UserCardNum { get; set; }
        public System.DateTime WorkTimes { get; set; }
        public string CompName { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool EnjoyHouse { get; set; }
        public bool EnjoyWarm { get; set; }
        public string UserType { get; set; }
    }
}
