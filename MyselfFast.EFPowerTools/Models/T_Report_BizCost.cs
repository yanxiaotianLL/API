using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Report_BizCost
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string CardId { get; set; }
        public string Fname { get; set; }
        public string Fno { get; set; }
        public decimal PerBenefit { get; set; }
        public decimal BizCost { get; set; }
        public decimal PerCost { get; set; }
        public decimal BizScale { get; set; }
        public decimal PerScale { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Income { get; set; }
        public decimal MonthRate { get; set; }
        public decimal YearRate { get; set; }
        public string AccountDate { get; set; }
        public System.DateTime OperateDate { get; set; }
    }
}
