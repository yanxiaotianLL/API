using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ben_Plan_Extend
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int Planid { get; set; }
        public string Addr { get; set; }
        public string ZipCode { get; set; }
    }
}
