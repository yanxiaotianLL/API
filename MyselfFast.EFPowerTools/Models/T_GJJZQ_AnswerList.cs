using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_GJJZQ_AnswerList
    {
        public int Id { get; set; }
        public int ApplyId { get; set; }
        public int TitleNo { get; set; }
        public string Answer { get; set; }
        public Nullable<int> Turn { get; set; }
        public int Sort { get; set; }
        public int IsDelete { get; set; }
    }
}
