using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Abdate
    {
        public int ID { get; set; }
        public int ActiveID { get; set; }
        public System.DateTime BaoDate { get; set; }
        public int Nums { get; set; }
        public int AdultNums { get; set; }
        public int ChildNums { get; set; }
        public string Memo { get; set; }
        public int SignCountNums { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public int ResNums { get; set; }
        public int TotalNums { get; set; }
        public int MaleNums { get; set; }
        public int FemaleNums { get; set; }
    }
}
