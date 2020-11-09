using myselfFast.Fund.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace myselfFast.ZFBZ.Core.Domain.Sys
{
    /// <summary>
    /// 系统级字典表记录配置相关信息
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
        /// 类型名称
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
        /// 字典描述
        /// </summary>
        public string DicDetail { get; set; }

        /// <summary>
        /// 只对广告位置有效
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