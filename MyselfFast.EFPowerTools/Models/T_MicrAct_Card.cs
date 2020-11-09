using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Card
    {
        public int Id { get; set; }
        public int ActiveID { get; set; }
        public string CardNo { get; set; }
        public string Password { get; set; }
        public int State { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public System.DateTime ActTime { get; set; }
        public int ActState { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public string UserName { get; set; }
        public string IDCard { get; set; }
        public int FesID { get; set; }
    }
}
