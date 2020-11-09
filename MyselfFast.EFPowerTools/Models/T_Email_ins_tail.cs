using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Email_ins_tail
    {
        public int Id { get; set; }
        public int PcId { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public string UseName { get; set; }
        public string Email { get; set; }
        public int State { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
