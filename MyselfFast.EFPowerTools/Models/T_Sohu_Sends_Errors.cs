using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sohu_Sends_Errors
    {
        public int Id { get; set; }
        public int Danid { get; set; }
        public System.DateTime SendDate { get; set; }
        public string ErrorText { get; set; }
    }
}
