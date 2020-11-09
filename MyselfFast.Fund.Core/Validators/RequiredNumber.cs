using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Validators
{
    /**********************************************************************************
     *项目名称	：FS.Core.API.Validator
     *项目描述  ：
     *类名称    ：RequiredNumber
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : RequiredNumber
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/8 21:58:48
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 应为整数类型具有默认值，所以Required并没有实际作用，所有单独实现一个验证标签验证整型不能为空即不能为0
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class RequiredNumberAttribute : ValidationAttribute
    {
        //public bool IsZero { get; set; }
        public override bool IsValid(object value)
        {
            return !string.Equals(value, 0);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!string.Equals(value, 0))
                return ValidationResult.Success;
            else
                return new ValidationResult(string.Format("{0} 不能为空", validationContext.DisplayName), new []{ validationContext.MemberName});
        }
    }
}
