using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_GJJZQ_TitleTurn
    {
        public int Id { get; set; }
        public int TitleNo { get; set; }
        public string TitleExplain { get; set; }
        public string Answer { get; set; }
        public string AnswerExplain { get; set; }
        public int Turn { get; set; }
        public int Sort { get; set; }
        public string WarmPrompt { get; set; }
    }
}
