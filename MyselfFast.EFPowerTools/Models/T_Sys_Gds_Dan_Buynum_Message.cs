using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Gds_Dan_Buynum_Message
    {
        public int Id { get; set; }
        public int Memsour { get; set; }
        public int Orderid { get; set; }
        public int Fesid { get; set; }
        public int Planid { get; set; }
        public int Chgnum { get; set; }
        public System.DateTime Gendate { get; set; }
        public System.DateTime Checkdate { get; set; }
        public int State { get; set; }
    }
}
