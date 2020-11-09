using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.HuKouSettled
{
    [Serializable]
    public partial class T_HK_Settled_FileItem : BaseEntity
    {
        public int Id { get; set; }
        public string MaritalStatus { get; set; }
        public string CensusRegister { get; set; }
        public string MigrationType { get; set; }
        public string Aitem { get; set; }
        public string Bitem { get; set; }
        public string Citem { get; set; }
    }
}
