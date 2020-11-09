using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************  
 * 类 名 称 :  T_Company表实体类                            
 * 版 本 号 :  v1.0.0.0                              
 * 说    明 :  企业信息表                            
 * 作    者 :                                        
 * 创建时间 : 2020/2/14 18:23:51                                
**************************************************/
namespace myselfFast.ZFBZ.Core.Domain.Company
{
    public class T_Company : BaseEntity 
    {

        /// <summary>     
        ///  企业性质 企业性质    
        /// </summary>     
        public string CompanyProperty { get; set; }
        /// <summary>     
        ///  统一社会信用代码    
        /// </summary>     
        public string CreditCode { get; set; }
        /// <summary>     
        ///  企业名称 企业名称    
        /// </summary>     
        public string CompanyName { get; set; }
        /// <summary>     
        ///  注册地址    
        /// </summary>     
        public string RegAddress { get; set; }
        /// <summary>
        /// 注册邮编
        /// </summary>
        public string RegAddressCode { get; set; }
        /// <summary>     
        ///  经营地址    
        /// </summary>     
        public string BusinessAddress { get; set; }

        /// <summary>     
        ///  经营地邮编  
        /// </summary>     
        public string BusinessAddressCode { get; set; }
        /// <summary>     
        ///  法人代表    
        /// </summary>     
        public string LegalRepresent { get; set; }
        /// <summary>     
        ///  联系人    
        /// </summary>     
        public string ContactPerson { get; set; }
        /// <summary>     
        ///  联系电话    
        /// </summary>     
        public string ContactPhone { get; set; }
        /// <summary>     
        ///  联系邮箱    
        /// </summary>     
        public string ContactEmail { get; set; }
        /// <summary>     
        ///  公司简介    
        /// </summary>     
        public string CompanyProfile { get; set; }
        /// <summary>     
        ///  营业执照 营业执照    
        /// </summary>     
        public string BusinessLicense { get; set; }
        /// <summary>
        /// 行业性质
        /// </summary>
        public string Trade { get; set; }
        /// <summary>
        /// 参保社区
        /// </summary>
        public string AreaCode { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}