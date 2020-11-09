using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Admin_Menu
    {
        public int Id { get; set; }
        public System.Guid GUID { get; set; }
        public int ParentID { get; set; }
        public string ParentOrder { get; set; }
        public string Orderby { get; set; }
        public string Subject { get; set; }
        public string ShortName { get; set; }
        public string Imgpath { get; set; }
        public string Urlpath { get; set; }
        public int Levelis { get; set; }
        public int Showtype { get; set; }
        public bool Urladdid { get; set; }
        public bool Urladdguid { get; set; }
        public bool IsInner { get; set; }
        public bool HasChilds { get; set; }
        public int Flag { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public string MenuPara { get; set; }
    }
}
