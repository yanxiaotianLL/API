using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_QrCode
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int Hno { get; set; }
        public string QrPicName { get; set; }
        public string FunctionType { get; set; }
        public string SubFunctionType { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }
    }
}
