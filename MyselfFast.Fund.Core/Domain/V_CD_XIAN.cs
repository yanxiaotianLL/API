using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain
{
    [Serializable]
    public partial class V_CD_XIAN : BaseEntity
    {
        public int SID { get; set; }
        public string PROVINCE { get; set; }
        public int id { get; set; }
        public string CNAME { get; set; }
        public string ENAME { get; set; }
        public int IDX { get; set; }
        public int IPID { get; set; }
        public bool SHOW { get; set; }
    }
}
