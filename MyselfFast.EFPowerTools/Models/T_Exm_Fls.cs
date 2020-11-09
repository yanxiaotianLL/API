using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Fls
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string BizLinkMan { get; set; }
        public string BizLinkPhone { get; set; }
        public string IsStdCard { get; set; }
        public int IsReturn { get; set; }
        public string PageStyle { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int ParentId { get; set; }
        public string FlsCode { get; set; }
        public int IsDelete { get; set; }
        public string BizDeptInfo { get; set; }
    }
}
