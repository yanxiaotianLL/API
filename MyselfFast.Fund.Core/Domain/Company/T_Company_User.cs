using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************  
 * 类 名 称 :  T_Company_User表实体类                            
 * 版 本 号 :  v1.0.0.0                              
 * 说    明 :  企业用户表                            
 * 作    者 :                                        
 * 创建时间 : 2020/2/14 18:26:00                                
**************************************************/
namespace myselfFast.ZFBZ.Core.Domain.Company
{

    public class T_Company_User : BaseEntity
    {
        /// <summary>     
        ///  登录账户名称 登录账户名称    
        /// </summary>     
        public string LoginName { get; set; }
        /// <summary>     
        ///  密码    
        /// </summary>     
        public string Pwd { get; set; }
        /// <summary>     
        ///  企业Id 企业Id    
        /// </summary>     
        public int CompanyId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
