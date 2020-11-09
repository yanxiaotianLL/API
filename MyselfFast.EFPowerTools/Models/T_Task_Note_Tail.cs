using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Task_Note_Tail
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public int Editno { get; set; }
        public int Typeid { get; set; }
        public string Typename { get; set; }
        public int Status { get; set; }
        public string Mark { get; set; }
        public int Oper { get; set; }
        public System.DateTime Createtime { get; set; }
    }
}
