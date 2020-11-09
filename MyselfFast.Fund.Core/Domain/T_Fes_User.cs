using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain
{
    [Serializable]
    public partial class T_Fes_User : BaseEntity
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Fname { get; set; }
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Hno { get; set; }
        public string Password { get; set; }
        public string PayPass { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Usedname { get; set; }
        public string Gno { get; set; }
        public int CardType { get; set; }
        public string CardId { get; set; }
        public System.DateTime Borth { get; set; }
        public string Sex { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Edustate { get; set; }
        public string EduName { get; set; }
        public int Mrstate { get; set; }
        public bool Wentifuli { get; set; }
        public int Verify { get; set; }
        public int SafeVerify { get; set; }
        public bool Isdeleted { get; set; }
        public System.DateTime Createtime { get; set; }
        public int custId { get; set; }
        public string custName { get; set; }
        public int busiCustId { get; set; }
        public string busiCustName { get; set; }
        public int conId { get; set; }
        public string conName { get; set; }
        public int acceId { get; set; }
        public string acceName { get; set; }
        public bool Workstate { get; set; }
        public bool ExtWorkstate { get; set; }
        public int InsType { get; set; }
        public string Open_Id { get; set; }
        public int Hmuserid { get; set; }
        public long UpdateId { get; set; }
        public int empStatus { get; set; }
        public bool IsBind { get; set; }
        public System.DateTime IsBindTime { get; set; }
        public bool IsNewSysSyn { get; set; }
        public System.DateTime IsNewSysSynTime { get; set; }
        public bool IsRealCheck { get; set; }
        public System.DateTime IsRealCheckTime { get; set; }
        public string UnionId { get; set; }
        public System.DateTime WechatBindTime { get; set; }
    }
}
