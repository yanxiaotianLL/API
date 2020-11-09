using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_PersonalFile
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int AccountType { get; set; }
        public int FilePlace { get; set; }
        public int IsReplace { get; set; }
        public string CurrentPlace { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int CertifyType { get; set; }
        public int Status { get; set; }
        public int FormalityId { get; set; }
    }
}
