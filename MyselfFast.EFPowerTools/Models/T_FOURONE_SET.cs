using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_FOURONE_SET
    {
        public int ID { get; set; }
        public bool ISCHINA { get; set; }
        public bool ISFOREIGN { get; set; }
        public bool ISBJ { get; set; }
        public bool ISWHOLE { get; set; }
        public bool ISSEND { get; set; }
        public bool ISDEPOTE { get; set; }
        public bool ISAGENCY { get; set; }
        public int Fesid { get; set; }
        public string CNAME { get; set; }
        public string LTD { get; set; }
        public string ZHIWEI { get; set; }
        public string HANGYE { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
        public int TIMES { get; set; }
        public System.DateTime CREATETIME { get; set; }
    }
}
