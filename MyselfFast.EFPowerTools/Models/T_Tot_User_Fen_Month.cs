using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Tot_User_Fen_Month
    {
        public int Id { get; set; }
        public int NY { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int Fentype { get; set; }
        public decimal FenLost { get; set; }
        public decimal FenAdded { get; set; }
        public decimal FenUsed { get; set; }
        public decimal FenBacked { get; set; }
        public decimal FenReturned { get; set; }
        public decimal FenTrsIn { get; set; }
        public decimal FenTrsOut { get; set; }
    }
}
