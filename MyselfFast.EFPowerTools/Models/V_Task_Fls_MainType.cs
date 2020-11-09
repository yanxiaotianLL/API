using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Task_Fls_MainType
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int TypeId { get; set; }
        public string Tasktype { get; set; }
        public bool Isdelete { get; set; }
    }
}
