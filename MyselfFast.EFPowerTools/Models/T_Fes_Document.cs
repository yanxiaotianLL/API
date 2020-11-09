using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Document
    {
        public int Id { get; set; }
        public string AttType { get; set; }
        public int Attid { get; set; }
        public string Filename { get; set; }
        public int Filesize { get; set; }
        public string Filetype { get; set; }
        public string Filedescript { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
    }
}
