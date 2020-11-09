using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_FinancialStatistics
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public System.DateTime StartDatetime { get; set; }
        public System.DateTime EndDatetime { get; set; }
        public System.DateTime CreateDatetime { get; set; }
        public int JianGuanCount { get; set; }
        public int OnsiteCount { get; set; }
        public int NoEntityCount { get; set; }
        public int AllCount { get; set; }
    }
}
