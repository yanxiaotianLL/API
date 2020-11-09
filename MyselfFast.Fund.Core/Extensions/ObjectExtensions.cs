using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /// <summary>
    ///     通用类型扩展方法类
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        ///     把对象类型转化为指定类型，转化失败时返回该类型默认值
        /// </summary>
        /// <typeparam name="T"> 动态类型 </typeparam>
        /// <param name="value"> 要转化的源对象 </param>
        /// <returns> 转化后的指定类型的对象，转化失败返回类型的默认值 </returns>
        public static T CastTo<T>(this object value)
        {
            object result;
            Type type = typeof(T);
            try
            {
                if (type.IsEnum)
                {
                    result = Enum.Parse(type, value.ToString());
                }
                else if (type == typeof(Guid))
                {
                    result = Guid.Parse(value.ToString());
                }
                else
                {
                    result = Convert.ChangeType(value, type);
                }
            }
            catch
            {
                result = default(T);
            }

            return (T)result;
        }

        /// <summary>
        ///     把对象类型转化为指定类型，转化失败时返回指定的默认值
        /// </summary>
        /// <typeparam name="T"> 动态类型 </typeparam>
        /// <param name="value"> 要转化的源对象 </param>
        /// <param name="defaultValue"> 转化失败返回的指定默认值 </param>
        /// <returns> 转化后的指定类型对象，转化失败时返回指定的默认值 </returns>
        public static T CastTo<T>(this object value, T defaultValue)
        {
            object result;
            Type type = typeof(T);
            try
            {
                result = type.IsEnum ? Enum.Parse(type, value.ToString()) : Convert.ChangeType(value, type);
            }
            catch
            {
                result = defaultValue;
            }
            return (T)result;
        }

        /// <summary>  
        /// 拷贝简单属性和公共字段  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="source"></param>  
        /// <param name="target"></param>  
        public static void CopyTo<T>(this object source, T target) where T : class
        {
            if (source == null)
            {
                return;
            }

            if (target == null)
            {
                throw new ApplicationException("target 未实例化！");
            }

            var properties = target.GetType().GetProperties();
            foreach (var targetPro in properties)
            {
                
                    //判断源对象是否存在与目标属性名字对应的源属性  
                    if (source.GetType().GetProperty(targetPro.Name) == null)
                    {
                        continue;
                    }
                    //判断是否枚举集合  
                    if (targetPro.PropertyType.IsGenericType && targetPro.PropertyType.GetGenericArguments()[0].IsEnum)
                    {
                        continue;
                    }
                    // 判断是否数组  
                    else if (targetPro.PropertyType.IsArray)
                    {
                        continue;
                    }
                    // 判断是否IList  
                    else if (targetPro.PropertyType.IsGenericType && targetPro.PropertyType.GetInterface("System.Collections.IEnumerable") != null)
                    {
                        continue;
                    }

                    var propertyValue = source.GetType().GetProperty(targetPro.Name).GetValue(source, null);
                    if (propertyValue != null)
                    {
                        if (propertyValue.GetType().IsEnum)
                        {
                            continue;
                        }

                        target.GetType().InvokeMember(targetPro.Name, BindingFlags.SetProperty, null, target, new object[] { propertyValue });
                    }
               
            }

            //返回所有公共字段  
            var targetFields = target.GetType().GetFields();
            foreach (var filed in targetFields)
            {
                
                    var tfield = source.GetType().GetField(filed.Name);
                    if (null == tfield)
                    {
                        //如果源对象中不包含这个公共字段则不处理  
                        continue;
                    }
                    //类型不一致不处理  
                    if (filed.FieldType.FullName != tfield.FieldType.FullName)
                    {
                        continue;
                    }
                    var fieldValue = tfield.GetValue(source);
                    if (fieldValue != null)
                    {
                        target.GetType().InvokeMember(filed.Name, BindingFlags.SetField, null, target, new object[] { fieldValue });
                    }
               
            }
        }
        /// <summary>  
        /// Copy Propertys and Fileds   
        /// 拷贝属性和公共字段  
        /// </summary>  
        /// <typeparam name="T"> </typeparam>  
        /// <param name="source"></param>  
        /// <param name="target"></param>  
        public static void CopyToAll<T>(this object source, T target) where T : class
        {
            if (source == null)
            {
                return;
            }

            if (target == null)
            {
                throw new ApplicationException("target 未实例化！");
            }


            var properties = target.GetType().GetProperties();
            foreach (var targetPro in properties)
            {
               
                    //判断源对象是否存在与目标属性名字对应的源属性  
                    if (source.GetType().GetProperty(targetPro.Name) == null)
                    {
                        continue;
                    }
                    //数据类型不相等  
                    if (targetPro.PropertyType.FullName != source.GetType().GetProperty(targetPro.Name).PropertyType.FullName)
                    {
                        continue;
                    }
                    var propertyValue = source.GetType().GetProperty(targetPro.Name).GetValue(source, null);
                    if (propertyValue != null)
                    {

                        target.GetType().InvokeMember(targetPro.Name, BindingFlags.SetProperty, null, target, new object[] { propertyValue });
                    }
               
            }
            //返回所有公共字段  
            var targetFields = target.GetType().GetFields();
            foreach (var filed in targetFields)
            {
               
                    var tfield = source.GetType().GetField(filed.Name);
                    if (null == tfield)
                    {
                        //如果源对象中不包含这个公共字段则不处理  
                        continue;
                    }
                    //类型不一致不处理  
                    if (filed.FieldType.FullName != tfield.FieldType.FullName)
                    {
                        continue;
                    } var fieldValue = tfield.GetValue(source);
                    if (fieldValue != null)
                    {
                        target.GetType().InvokeMember(filed.Name, BindingFlags.SetField, null, target, new object[] { fieldValue });
                    }
              
            }
        }
        /// <summary>
        /// 有鉴于xx数据库表为非空字段，特提供此方法简化开发流程
        /// </summary>
        /// <param name="source"></param>
        public static void SetNullToDefalut(this object source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source不能为空！");
            }
            Type type = source.GetType();
            if (!type.IsClass)
            {
                throw new ArgumentException("source必须为class类型！");
            }
            PropertyInfo[] propertys = type.GetProperties();
            if (propertys.Any())
            {
                foreach (var item in propertys)
                {
                    var value = item.GetValue(source);
                    if (value == null && !item.PropertyType.IsNullableType())
                    {
                       item.SetValue(source, "");
                    }
                    else if (value != null && item.PropertyType == typeof(DateTime) && (DateTime)value == DateTime.MinValue)
                    {
                        item.SetValue(source, new DateTime(1900, 1, 1));
                    }

                }
            }
        }
        /// <summary>
        /// 检查model的有效性
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool CheckModelState(this object source,ref string message)
        {
            var modelStateResult = new List<ValidationResult>();
            Validator.TryValidateObject(source, new ValidationContext(source),
                modelStateResult, true);
            if (modelStateResult.Any())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var r in modelStateResult)
                {
                    if (r.MemberNames != null && r.MemberNames.Any())
                    {
                        sb.Append(string.Format("{0}:{1}", r.MemberNames.Single(), r.ErrorMessage));
                    }
                }
                message = sb.ToString();
                return false;
            }
            return true;
        }
    }
}
