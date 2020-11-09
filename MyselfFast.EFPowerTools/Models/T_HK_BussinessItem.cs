using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_HK_BussinessItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal ItemFee { get; set; }
        public string BussinessName { get; set; }
    }
}
