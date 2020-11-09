using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain
{
    [Serializable]
    public partial class T_Helo_MsgLog : BaseEntity
    {
        public int Id { get; set; }
        public string MobileNo { get; set; }
        public System.DateTime Sendtime { get; set; }
        public System.DateTime TrySendtime { get; set; }
        public int TryTimes { get; set; }
        public int Status { get; set; }
        public int isNeedTry { get; set; }
        public string MsgContent { get; set; }
        public string errorContent { get; set; }
        public int IsDel { get; set; }
        public string ElectType { get; set; }
        public string ElectSource { get; set; }
        public int IsNowSend { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string LinkId { get; set; }
    }
}
