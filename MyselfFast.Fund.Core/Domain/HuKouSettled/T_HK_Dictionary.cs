using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.HuKouSettled
{
    [Serializable]
    public partial class T_HK_Dictionary : BaseEntity
    {
        public int Id { get; set; }
        public string DictValue { get; set; }
        public string DictName { get; set; }
        public string KeyValue { get; set; }
        public string keyDesc { get; set; }
        public int Flag { get; set; }
        public int OrderNum { get; set; }
        public string Remark { get; set; }
        public string ExampleScr { get; set; }
    }
}
