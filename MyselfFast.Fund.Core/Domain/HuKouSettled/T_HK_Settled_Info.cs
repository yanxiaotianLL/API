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
        public string UsedName { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public int Height { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string Blood { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string ContactPhone { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string EmerContactName { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string EmerContactPhone { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string District { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string Address { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string DadName { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string MumName { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string CpName { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public System.DateTime MigrationStart { get; set; }
        public System.DateTime MigrationEnd { get; set; }
        public System.DateTime ChekcDate { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public System.DateTime SubmitDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int State { get; set; }
        public int IsCurrent { get; set; }
        public System.DateTime AdminTime { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public int AdminId { get; set; }//�ǼǱ���޸ĵ���Ϣ
        public string AdminName { get; set; }//�ǼǱ���޸ĵ���Ϣ
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
        /// ��ݵ���
        /// </summary>
        public string ExpressNum { get; set; }

        /// <summary>
        /// ��ݹ�˾
        /// </summary>
        public string ExpressName { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime ExpressDate { get; set; }
    }
}
