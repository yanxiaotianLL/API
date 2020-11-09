using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Contract
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int SignType { get; set; }
        public int DeliveryId { get; set; }
        public int IsMerge { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }
        public int ContractType { get; set; }
        public string ContractAddress { get; set; }
        public int LeavingCertificateStatus { get; set; }
        public string LeavingCertificateDetails { get; set; }
        public int ContractStatus { get; set; }
        public string ContractDetails { get; set; }
        public int FormalityId { get; set; }
    }
}
