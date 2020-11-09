using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_EmployeeCard
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int SubmitFileType { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DeliveryId { get; set; }
        public int IsMerge { get; set; }
        public int Status { get; set; }
        public string RegistrationNum { get; set; }
        public string ResidenceAdd { get; set; }
        public string AgencyAdd { get; set; }
        public string CradValidity { get; set; }
        public string Resume { get; set; }
        public int PhotoStatus { get; set; }
        public string PhotoProveInfo { get; set; }
        public int IdCopyStatus { get; set; }
        public string IdCopyProveInfo { get; set; }
        public int AgencyCopyStatus { get; set; }
        public string AgencyCopyProveInfo { get; set; }
        public int EmpCardStatus { get; set; }
        public string EmpCardProveInfo { get; set; }
        public int FormalityId { get; set; }
    }
}
