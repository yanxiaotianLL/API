using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Fenback_ins_tail
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int FenType { get; set; }
        public string Fno { get; set; }
        public int Fesid { get; set; }
        public int PcId { get; set; }
        public int State { get; set; }
        public decimal Fen { get; set; }
        public string Optype { get; set; }
        public string Opcause { get; set; }
        public string Bak { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public System.DateTime ImportTime { get; set; }
    }
}
