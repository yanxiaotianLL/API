using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.HuKouSettled
{
    [Serializable]
    public partial class T_HK_Settled_Info : BaseEntity
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string OrderId { get; set; }
        public string RecordState { get; set; }
        public string MaritalStatus { get; set; }
        public string CensusRegister { get; set; }
        public string MigrationType { get; set; }
        public string UsedName { get; set; }//登记表可修改的信息
        public int Height { get; set; }//登记表可修改的信息
        public string Blood { get; set; }//登记表可修改的信息
        public string ContactPhone { get; set; }//登记表可修改的信息
        public string EmerContactName { get; set; }//登记表可修改的信息
        public string EmerContactPhone { get; set; }//登记表可修改的信息
        public string District { get; set; }//登记表可修改的信息
        public string Address { get; set; }//登记表可修改的信息
        public string DadName { get; set; }//登记表可修改的信息
        public string MumName { get; set; }//登记表可修改的信息
        public string CpName { get; set; }//登记表可修改的信息
        public System.DateTime MigrationStart { get; set; }
        public System.DateTime MigrationEnd { get; set; }
        public System.DateTime ChekcDate { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public System.DateTime SubmitDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int State { get; set; }
        public int IsCurrent { get; set; }
        public System.DateTime AdminTime { get; set; }//登记表可修改的信息
        public int AdminId { get; set; }//登记表可修改的信息
        public string AdminName { get; set; }//登记表可修改的信息
        public int IsAgain { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string Opinion { get; set; }
        public string Reason { get; set; }
        public string FileItem { get; set; }
        public System.DateTime OperateTime { get; set; }

        public int Pid { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string ExpressNum { get; set; }

        /// <summary>
        /// 快递公司
        /// </summary>
        public string ExpressName { get; set; }

        /// <summary>
        /// 快递时间
        /// </summary>
        public DateTime ExpressDate { get; set; }
    }
}
