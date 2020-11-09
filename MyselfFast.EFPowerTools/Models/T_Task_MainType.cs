using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_MainType
    {
        public int ID { get; set; }
        public string Tasktype { get; set; }
        public bool Isdelete { get; set; }
        public int OldId { get; set; }
    }
}
