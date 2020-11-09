using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_TASK_MENU_EXT_FLS
    {
        public int Fid { get; set; }
        public string ParentBy { get; set; }
        public int Id { get; set; }
        public string OrderBy { get; set; }
        public string MenuText { get; set; }
        public string Url { get; set; }
        public string Oldurl { get; set; }
        public int Menutype { get; set; }
    }
}
