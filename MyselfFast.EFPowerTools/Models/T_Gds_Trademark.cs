using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Trademark
    {
        public int Id { get; set; }
        public int Parentid { get; set; }
        public long Tid { get; set; }
        public int Grd { get; set; }
        public string Tname { get; set; }
        public string Ename { get; set; }
        public string Script { get; set; }
        public string Img { get; set; }
        public int Idx { get; set; }
        public bool Isdbl { get; set; }
        public string Links { get; set; }
        public int Showtype { get; set; }
        public bool State { get; set; }
        public int Ctype { get; set; }
        public string Frontimg { get; set; }
        public int OperId { get; set; }
        public string Oper { get; set; }
        public System.DateTime OperTime { get; set; }
        public bool IsWxShow { get; set; }
    }
}
