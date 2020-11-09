using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Gds_Col_Rl
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public long Cid { get; set; }
        public int Grd { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Script { get; set; }
        public string Img { get; set; }
        public int Idx { get; set; }
        public bool Isdbl { get; set; }
        public string Links { get; set; }
        public int Showtype { get; set; }
        public bool State { get; set; }
        public string Frontimg { get; set; }
        public int PID3 { get; set; }
        public long CID3 { get; set; }
        public int PID2 { get; set; }
        public long CID2 { get; set; }
        public int PID1 { get; set; }
        public long CID1 { get; set; }
    }
}
