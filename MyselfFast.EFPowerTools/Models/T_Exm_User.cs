using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_User
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public string CheckNo { get; set; }
        public int CheckcardId { get; set; }
        public string PassWord { get; set; }
        public string PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonidType { get; set; }
        public string PersonSex { get; set; }
        public System.DateTime PersonBirthday { get; set; }
        public string PersonMerry { get; set; }
        public string PersonMobile { get; set; }
        public string PersonComp { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int Year { get; set; }
        public int JigouId { get; set; }
        public string ChooseJigou { get; set; }
        public string ContentMsg { get; set; }
        public int PartId { get; set; }
        public string ParentName { get; set; }
        public int CityId { get; set; }
        public string ChooseCity { get; set; }
        public int ReportAuth { get; set; }
        public int Adminuid { get; set; }
        public string AdminName { get; set; }
        public System.DateTime LastDatetime { get; set; }
        public int HistoryId { get; set; }
        public string Link { get; set; }
        public int ProjectId { get; set; }
        public int Fid { get; set; }
        public string Education { get; set; }
        public int State { get; set; }
        public System.DateTime SubTime { get; set; }
        public System.DateTime CheckDate { get; set; }
        public System.DateTime WriteDate { get; set; }
        public System.DateTime BackReportTime { get; set; }
        public string Scales { get; set; }
        public bool IsIntervention { get; set; }
        public int CheckType { get; set; }
        public string OtherOrderNum { get; set; }
        public string OtherCardNum { get; set; }
        public int IsCustom { get; set; }
        public string CanReason { get; set; }
        public int DataFrom { get; set; }
        public bool IsExport_Other { get; set; }
        public bool IsOver_Other { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public bool IsBackReport { get; set; }
        public bool Isdelete { get; set; }
        public bool IsUserSelf { get; set; }
        public int ReportState { get; set; }
        public System.DateTime ReportSendTime { get; set; }
        public int getReportType { get; set; }
        public string reportaddress { get; set; }
        public string reportuname { get; set; }
        public string reportuphone { get; set; }
        public string bakinfo { get; set; }
        public string backstageinfo { get; set; }
        public string KdCompany { get; set; }
        public string Sendno { get; set; }
        public System.DateTime Senddate { get; set; }
        public string WorkNo { get; set; }
        public bool IsSendToCheck { get; set; }
        public bool IsSendReport { get; set; }
        public bool IsSendReportFile { get; set; }
        public string mnPackageId { get; set; }
        public string Cardyewubu { get; set; }
        public int CompareAuthorize { get; set; }
    }
}
