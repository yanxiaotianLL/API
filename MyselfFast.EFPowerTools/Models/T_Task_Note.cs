using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_Note
    {
        public int Id { get; set; }
        public string Tasknum { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int Typeid { get; set; }
        public string Tasktype { get; set; }
        public int Editno { get; set; }
        public System.DateTime Createdate { get; set; }
        public int Createtype { get; set; }
        public string Onsiteid { get; set; }
        public System.DateTime Acceptdate { get; set; }
        public System.DateTime Enddate { get; set; }
        public int Status { get; set; }
        public string Bak { get; set; }
    }
}
