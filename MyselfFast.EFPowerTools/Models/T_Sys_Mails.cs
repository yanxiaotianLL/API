using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Mails
    {
        public int Id { get; set; }
        public string Sour { get; set; }
        public int Fesid { get; set; }
        public int SourId { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Subtext { get; set; }
        public System.DateTime PreSendTime { get; set; }
        public System.DateTime LastSendTime { get; set; }
        public int Times { get; set; }
        public int State { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
