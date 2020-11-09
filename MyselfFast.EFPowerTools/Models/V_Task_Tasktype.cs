using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Task_Tasktype
    {
        public int Id { get; set; }
        public int Typeid { get; set; }
        public string Tasktype { get; set; }
        public int SubId { get; set; }
        public string Title { get; set; }
        public string Script { get; set; }
        public int WakeDays { get; set; }
        public bool Isdelete { get; set; }
    }
}
