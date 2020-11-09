using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Fes_User_FenFrost_ins_tail
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int FenType { get; set; }
        public string Fno { get; set; }
        public int Fesid { get; set; }
        public int PcId { get; set; }
        public int State { get; set; }
        public string Optype { get; set; }
        public string Opcause { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public System.DateTime ImportTime { get; set; }
        public int Hno { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Usedname { get; set; }
        public string Gno { get; set; }
        public string CardId { get; set; }
        public string Mobile { get; set; }
    }
}
