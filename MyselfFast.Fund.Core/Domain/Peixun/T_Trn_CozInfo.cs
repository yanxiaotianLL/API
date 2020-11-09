using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Peixun
{
    [Serializable]
    public partial class T_Trn_CozInfo : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsOpen { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int Credit { get; set; }
        public int OpenDegree { get; set; }
        public string VideoId { get; set; }
        public string ThumbnailSrc { get; set; }
        public string TrnFileSrc { get; set; }
        public int IsText { get; set; }
        public decimal SumMin { get; set; }
        public string TrnContent { get; set; }
        public string LabelIds { get; set; }
        public int IsDelete { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreatTime { get; set; }
        public int EditUserId { get; set; }
        public System.DateTime EditTime { get; set; }
    }
}
