using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Ord_Dept
    {
        public int Id { get; set; }
        public int Sid { get; set; }
        public string BizDept { get; set; }
        public string BizDeptSalesman { get; set; }
        public string SalesmanStatus { get; set; }
        public int SalesmanHno { get; set; }
        public string BizDeptId { get; set; }
        public int BizDeptType { get; set; }
        public string BizDeptTypeVal { get; set; }
        public int IsSend { get; set; }
        public string CostCenterName { get; set; }
        public System.DateTime OperateTime { get; set; }
    }
}
