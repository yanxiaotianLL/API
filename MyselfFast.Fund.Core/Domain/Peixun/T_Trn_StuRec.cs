using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Peixun
{
    [Serializable]
    public partial class T_Trn_StuRec:BaseEntity
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int IsFinish { get; set; }
        public decimal RecPercent { get; set; }
        public int LastPoint { get; set; }
        public int FinishPct { get; set; }
        public int CozInfoId { get; set; }
    }
}
