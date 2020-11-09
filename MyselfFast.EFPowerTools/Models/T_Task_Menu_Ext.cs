using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_Menu_Ext
    {
        public int Id { get; set; }
        public string ParentBy { get; set; }
        public string OrderBy { get; set; }
        public string MenuText { get; set; }
        public string Url { get; set; }
        public string Oldurl { get; set; }
        public int Menutype { get; set; }
    }
}
