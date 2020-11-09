using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sch_Plan
    {
        public int Id { get; set; }
        public int Grd { get; set; }
        public string Orderby { get; set; }
        public int Parentid { get; set; }
        public string PlanName { get; set; }
        public string JianJie { get; set; }
        public string ReceptPage { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
        public int ProductCategory { get; set; }
        public bool PlanAttribute { get; set; }
        public int ActivateSort { get; set; }
        public System.DateTime Activatedate { get; set; }
        public int ActivedBefore { get; set; }
        public int ActivedAfter { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.DateTime DeadlineDate { get; set; }
        public string Description { get; set; }
        public string PageType { get; set; }
        public int State { get; set; }
        public int Belongto { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public System.DateTime Edittime { get; set; }
        public int Minsels { get; set; }
        public int Maxsels { get; set; }
        public int SelLimit { get; set; }
        public decimal Rate { get; set; }
        public bool Repeatable { get; set; }
        public int ShareFrom { get; set; }
        public bool IsForShared { get; set; }
        public bool ShowInList { get; set; }
        public string Img { get; set; }
        public int PlanArea { get; set; }
        public int Fid { get; set; }
        public bool NeedExt { get; set; }
        public bool IsOnlyWorking { get; set; }
        public string ExtName { get; set; }
        public bool IsLeaf { get; set; }
        public bool ExtFenAble { get; set; }
        public int PriceShowType { get; set; }
        public string WxIcon { get; set; }
        public string PcImg { get; set; }
        public bool IsNeedDocking { get; set; }
    }
}
