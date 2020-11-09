using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Peixun
{
    [Serializable]
    public partial class T_Trn_Stu:BaseEntity
    {
        public int FesId { get; set; }
        public string PersonName { get; set; }
        public string PersonId { get; set; }
        public int CardType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int IsActive { get; set; }
        public System.DateTime ActiveTime { get; set; }
        public string LabelIds { get; set; }
        public int IsDelete { get; set; }
        public int Id { get; set; }
        public int EditUserId { get; set; }
        public System.DateTime EditTime { get; set; }
    }
}
