using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Msg
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public int Checkuserid { get; set; }
        public string PersonMobile { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public string MsgContent { get; set; }
        public int SendType { get; set; }
        public int IsSend { get; set; }
        public System.DateTime SubTime { get; set; }
        public int IsDel { get; set; }
        public int Fid { get; set; }
        public int checktype { get; set; }
    }
}
