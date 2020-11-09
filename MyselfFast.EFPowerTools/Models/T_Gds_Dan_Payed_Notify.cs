using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Payed_Notify
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int OrderState { get; set; }
        public int State { get; set; }
        public System.DateTime Gendate { get; set; }
    }
}
