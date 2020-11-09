using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class HV_TASKTAIL
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public int Mno { get; set; }
        public int Editno { get; set; }
        public int Tasktypeid { get; set; }
        public string Tasktype { get; set; }
        public int Typeid { get; set; }
        public string Typename { get; set; }
        public int Status { get; set; }
        public string Mark { get; set; }
        public int Oper { get; set; }
        public System.DateTime Createtime { get; set; }
        public string Script { get; set; }
        public Nullable<int> ONSITE { get; set; }
        public string RealName { get; set; }
        public string Cname { get; set; }
        public int Fid { get; set; }
        public string ltd { get; set; }
        public int Hno { get; set; }
        public string Cid { get; set; }
        public string Bak { get; set; }
    }
}
