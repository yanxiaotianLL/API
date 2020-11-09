using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Email
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Title { get; set; }
        public string links { get; set; }
        public string Description { get; set; }
        public string FiledList { get; set; }
        public int State { get; set; }
        public int Createrid { get; set; }
        public string Creatername { get; set; }
        public System.DateTime Createtime { get; set; }
    }
}
