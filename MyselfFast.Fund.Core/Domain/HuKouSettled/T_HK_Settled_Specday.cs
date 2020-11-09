using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.HuKouSettled
{
    [Serializable]
    public partial class T_HK_Settled_Specday : BaseEntity
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int SpecType { get; set; }
        public int IsUse { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
    }
}
