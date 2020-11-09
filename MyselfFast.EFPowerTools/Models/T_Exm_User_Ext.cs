using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_User_Ext
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int BoeApplicantId { get; set; }
        public string BoeApplicantCode { get; set; }
        public int BoeJobId { get; set; }
        public int BoeRecruitCategory { get; set; }
        public int BoeStatusId { get; set; }
        public System.DateTime OperateTime { get; set; }
        public int BoeIsSendReport { get; set; }
        public System.DateTime BoeSendReportTime { get; set; }
        public int IsDelete { get; set; }
    }
}
