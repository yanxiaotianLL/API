using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Onl_Workexp
    {
        public int Id { get; set; }
        public int Danid { get; set; }
        public string UserType { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string CompName { get; set; }
    }
}
