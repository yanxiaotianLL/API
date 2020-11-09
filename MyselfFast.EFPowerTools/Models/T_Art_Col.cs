using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Art_Col
    {
        public int Id { get; set; }
        public int Clubid { get; set; }
        public string Ctype { get; set; }
        public string Cname { get; set; }
        public string Script { get; set; }
        public string Img { get; set; }
        public string Links { get; set; }
        public bool Show { get; set; }
        public bool State { get; set; }
    }
}
