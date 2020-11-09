using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Tb_User_Ext7
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string MaternityLeave { get; set; }
        public int PersonalState { get; set; }
        public int RecordState { get; set; }
        public int MemberState { get; set; }
        public int SocialState { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    }
}
