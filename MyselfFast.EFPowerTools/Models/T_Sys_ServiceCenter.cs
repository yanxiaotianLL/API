using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_ServiceCenter
    {
        public int Id { get; set; }
        public string BusinessDep { get; set; }
        public string SerCenterName { get; set; }
        public string SerCenterAdd { get; set; }
        public string ContactUser { get; set; }
        public string ContactMobel { get; set; }
        public string SerCenPhone { get; set; }
    }
}
