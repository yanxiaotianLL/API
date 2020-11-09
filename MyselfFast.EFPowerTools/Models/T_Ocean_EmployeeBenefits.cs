using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ocean_EmployeeBenefits
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public string UserName { get; set; }
        public int BirthdayBenefits { get; set; }
        public int LaundryBenefits { get; set; }
        public int LaundryGoodLife { get; set; }
        public int DragonBoatFestival { get; set; }
        public int LaundryGoodLifezq { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
    }
}
