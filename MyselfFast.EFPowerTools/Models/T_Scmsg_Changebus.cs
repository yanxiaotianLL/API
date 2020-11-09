using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Scmsg_Changebus
    {
        public int ID { get; set; }
        public string BusNumber { get; set; }
        public int SortId { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public string UserNmae { get; set; }
        public string Sex { get; set; }
        public string UserKey { get; set; }
        public string UserCard { get; set; }
        public string Depart { get; set; }
        public string Company { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int State { get; set; }
        public string ReMsg { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CAUSE { get; set; }
        public string changeId { get; set; }
        public int Cuiban { get; set; }
        public string Sign { get; set; }
        public string ChangeItems { get; set; }
    }
}
