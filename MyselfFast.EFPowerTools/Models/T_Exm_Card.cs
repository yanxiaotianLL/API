using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Card
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PackageId { get; set; }
        public string CheckNo { get; set; }
        public string PassWord { get; set; }
        public string CardRule { get; set; }
        public string CardRule_Old { get; set; }
        public string CheckvalNo { get; set; }
        public int CheckvalId { get; set; }
        public int Fid { get; set; }
        public int Year { get; set; }
        public int IsDelete { get; set; }
        public int Fesid { get; set; }
        public int IsBind { get; set; }
        public int IsCustom { get; set; }
        public int OldPackageId { get; set; }
        public string OldcheckNo { get; set; }
        public int OrderId { get; set; }
        public int Sort { get; set; }
        public int BusinessId { get; set; }
        public string Business { get; set; }
        public int PreId { get; set; }
        public string PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSex { get; set; }
        public string PackageIds { get; set; }
        public int UseState { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LStart { get; set; }
        public System.DateTime LEnd { get; set; }
        public int LDays { get; set; }
        public int Old_ProjectId { get; set; }
        public int Divid { get; set; }
        public bool IsIntervention { get; set; }
        public string BizDept { get; set; }
        public int IsOwnUse { get; set; }
        public int BizFid { get; set; }
        public int IsTestCard { get; set; }
        public int OrderItemId { get; set; }
        public string BizDeptSalesman { get; set; }
    }
}
