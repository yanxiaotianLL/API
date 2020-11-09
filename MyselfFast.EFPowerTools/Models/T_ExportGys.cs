using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_ExportGys
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public int Userid { get; set; }
        public string UserName { get; set; }
        public string Path { get; set; }
        public int State { get; set; }
        public string Message { get; set; }
        public string PramsJson { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime OutsTime { get; set; }
    }
}
