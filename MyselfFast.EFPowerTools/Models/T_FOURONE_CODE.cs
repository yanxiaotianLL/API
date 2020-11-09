using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_FOURONE_CODE
    {
        public int ID { get; set; }
        public string FKEY { get; set; }
        public string FTEXT { get; set; }
        public string MKEY { get; set; }
        public string MTEXT { get; set; }
        public string TKEY { get; set; }
        public string TTEXT { get; set; }
        public string PARAM { get; set; }
        public bool ISCHINA { get; set; }
        public bool ISFOREIGN { get; set; }
        public bool ISBJ { get; set; }
        public bool ISWHOLE { get; set; }
        public bool ISSEND { get; set; }
        public bool ISDEPOTE { get; set; }
        public bool ISAGENCY { get; set; }
    }
}
