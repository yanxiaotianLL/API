using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_Guanggao
    {
        public long Id { get; set; }
        public string Place { get; set; }
        public string Title { get; set; }
        public string Linkpath { get; set; }
        public string Script { get; set; }
        public string Img { get; set; }
        public string Tag { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Hits { get; set; }
        public bool Istot { get; set; }
        public int Thishits { get; set; }
        public int Isshow { get; set; }
        public int Idx { get; set; }
    }
}
