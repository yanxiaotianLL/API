using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Pay_Notify
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int PayState { get; set; }
        public int State { get; set; }
        public int Times { get; set; }
        public System.DateTime CheckDate { get; set; }
        public string Msg { get; set; }
    }
}
