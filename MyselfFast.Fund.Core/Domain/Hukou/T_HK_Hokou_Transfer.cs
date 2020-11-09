using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Hukou
{
    [Serializable]
    public partial class T_HK_Hokou_Transfer : BaseEntity
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public string Uniqueno { get; set; }
        public int Addressid { get; set; }
        public int Transtype { get; set; }
        public int Transtableid { get; set; }
        public string Billtitle { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        public string Remark { get; set; }
        public int Fesid { get; set; }
        public System.DateTime Optime { get; set; }
        public System.DateTime Committime { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public int Isback { get; set; }
        public bool Isdelete { get; set; }
        public int Flag { get; set; }
        public string Native { get; set; }
        public string Phone { get; set; }
        public string NewCompany { get; set; }
        public string EmigrationReason { get; set; }
        public string EmigrationAddress { get; set; }
        public string CancelReason { get; set; }
        public string ToCountry { get; set; }
        public System.DateTime Inhometime { get; set; }
        public System.DateTime Emigrationtime { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; }
        public string CardId { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Usage { get; set; }
        public string Username { get; set; }
        public int FrontIDCard { get; set; }
        public int ReverseIDCard { get; set; }
        public int PermitCard { get; set; }
    }
}
