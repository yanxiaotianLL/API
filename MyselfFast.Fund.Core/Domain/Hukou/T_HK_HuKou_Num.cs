using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Hukou
{
    [Serializable]
    public partial class T_HK_HuKou_Num : BaseEntity
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int UseageId { get; set; }
        public string Useage { get; set; }
        public int Num { get; set; }
        public bool Isdelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
