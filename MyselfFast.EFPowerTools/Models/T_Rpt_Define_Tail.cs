using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Rpt_Define_Tail
    {
        public int Id { get; set; }
        public int Rptid { get; set; }
        public int Idx { get; set; }
        public string FieldName { get; set; }
        public string RptTitle { get; set; }
        public bool IsQry { get; set; }
        public bool IsShow { get; set; }
        public bool IsOut { get; set; }
    }
}
