using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Packagetemp
    {
        public int Id { get; set; }
        public string CardRule { get; set; }
        public string Name { get; set; }
        public string BriefInfo { get; set; }
        public string PContext { get; set; }
        public string EName { get; set; }
        public int Fid { get; set; }
        public string ComName { get; set; }
        public decimal Pay { get; set; }
        public int Year { get; set; }
        public string Duringtime { get; set; }
        public string Jigous { get; set; }
        public string Uppackages { get; set; }
        public int Status { get; set; }
        public decimal CostPrice { get; set; }
        public int PackageType { get; set; }
        public int CheckType { get; set; }
        public int IsFamily { get; set; }
        public int IsCustom { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public bool Isdelete { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Pic { get; set; }
        public bool IsIntervention { get; set; }
        public bool IsOnline { get; set; }
        public string JigouPage { get; set; }
    }
}
