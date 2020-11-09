using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Menu
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int Idx { get; set; }
        public string MenuText { get; set; }
        public string Url { get; set; }
        public string Context { get; set; }
        public string Target { get; set; }
    }
}
