using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Peixun
{
    [Serializable] 
    public partial class T_Trn_Label:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int IsDelete { get; set; }
        public string AliId { get; set; }
    }
}
