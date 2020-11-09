using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_Type
    {
        public int Id { get; set; }
        public int Typeid { get; set; }
        public int SubId { get; set; }
        public string Title { get; set; }
        public string Script { get; set; }
        public int WakeDays { get; set; }
        public bool Isdelete { get; set; }
        public int OldId { get; set; }
    }
}
