using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Business_Fls
    {
        public int Id { get; set; }
        public int custId { get; set; }
        public string custName { get; set; }
        public int busiCustId { get; set; }
        public string busiCustName { get; set; }
        public bool HasMidical { get; set; }
    }
}
