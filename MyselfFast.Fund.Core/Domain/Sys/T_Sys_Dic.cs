using myselfFast.Fund.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace myselfFast.ZFBZ.Core.Domain.Sys
{
    /// <summary>
    /// ϵͳ���ֵ���¼���������Ϣ
    /// </summary>
    public partial class T_Sys_Dic : BaseEntity
    {
        /// <summary>
        /// [Code]
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// [ChineseName]
        /// </summary>
        public string ChineseName { get; set; }

        /// <summary>
        /// [EglishName]
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// [DicType]
        /// </summary>
        public string DicType { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string DicTypeName { get; set; }

        /// <summary>
        /// [SortValue]
        /// </summary>
        public Nullable<int> SortValue { get; set; }

        /// <summary>
        /// [ParentId]
        /// </summary>
        public Nullable<int> ParentId { get; set; }

        /// <summary>
        /// [CreateUser]
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// �ֵ�����
        /// </summary>
        public string DicDetail { get; set; }

        /// <summary>
        /// ֻ�Թ��λ����Ч
        /// </summary>
        [NotMapped]
        public bool IsCarousel
        {
            get
            {
                if (Code != null)
                    return this.Code == "1" || this.Code == "2";
                return false;
            }
        }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}