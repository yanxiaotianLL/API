using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Account
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public string Uno { get; set; }
        public int Fid { get; set; }
        public string Fno { get; set; }
        public int FenType { get; set; }
        public string FenTypeName { get; set; }
        public string AccountName { get; set; }
        public int FenTag { get; set; }
        public string FenStans { get; set; }
        public bool Spread { get; set; }
        public bool Fenable { get; set; }
        public decimal Fenall { get; set; }
        public decimal Fencur { get; set; }
        public decimal Fenlock { get; set; }
        public int Fenstate { get; set; }
        public System.DateTime Fenlimit { get; set; }
        public string Bak { get; set; }
        public int RecycleFen { get; set; }
    }
}
