using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain
{
    [Serializable]
    public partial class T_Tb_dictionarylist : BaseEntity
    {
        public int id { get; set; }
        public string dcode { get; set; }
        public string dname_en { get; set; }
        public string dname { get; set; }
        public int dtype { get; set; }
    }
}
