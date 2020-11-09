using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Fls_User
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int FesId { get; set; }
        public int IsCurrentUse { get; set; }
        public System.DateTime OperateTime { get; set; }
    }
}
