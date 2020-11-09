using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Extensition
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Extensition
     *项目描述  ：
     *类名称    ：ValidateExt
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ValidateExt
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/8 19:00:18
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class ValidateExt
    {
        public static List<ValidationResult> Validate(object instance)
        {
           /* var validationResults = new List<ValidationResult>();
            MetadataTypeAttribute metaTypeAttr = instance.GetType().GetCustomAttributes(typeof(MetadataTypeAttribute), true)
            .OfType<MetadataTypeAttribute>().FirstOrDefault();

            if (metaTypeAttr == null) return validationResults;

            TypeDescriptor.AddProvider(
            new AssociatedMetadataTypeTypeDescriptionProvider(instance.GetType(), metaTypeAttr.MetadataClassType),
            instance.GetType());

            ValidationContext vc = new ValidationContext(instance, null, null);
            Validator.TryValidateObject(instance, vc, validationResults, true);

            return validationResults;
            */

            var validationResults = new List<ValidationResult>();
            //MetadataTypeAttribute metaTypeAttr = instance.GetType().GetCustomAttributes(typeof(MetadataTypeAttribute), true)
            //.OfType<MetadataTypeAttribute>().FirstOrDefault();

            //if (metaTypeAttr == null) return validationResults;

            //TypeDescriptor.AddProvider(
            //new AssociatedMetadataTypeTypeDescriptionProvider(instance.GetType(), metaTypeAttr.MetadataClassType),
            //instance.GetType());

            //ValidationContext vc = new ValidationContext(instance, null, null);
            //Validator.TryValidateObject(instance, vc, validationResults, true);

            return validationResults;
        }
    }
}
