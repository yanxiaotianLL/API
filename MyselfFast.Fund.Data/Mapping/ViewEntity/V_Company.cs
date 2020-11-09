using myselfFast.Fund.Core;
using myselfFast.Fund.Data.Mapping;
using myselfFast.ZFBZ.Core.Domain.Company;
using myselfFast.ZFBZ.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Data.ViewEntity
{
    public class V_Company:BaseEntity
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
        ///  经营地址    
        /// </summary>     
        public string BusinessAddress { get; set; }
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
        /// 补贴类型
        /// </summary>
        public int? SubsidyTypes { get; set; }
        /// <summary>
        /// 预约名称
        /// </summary>
        public string AppointmentTypes { get; set; }
        public DateTime? AppointTime { get; set; }
        public string Status { get; set; }
        public int? AppointId { get; set; }
        public int CompanyId { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Note { get; set; }
        public string AppointSign { get; set; }
        public string AreaName { get; set; }
        public string Trade { get; set; }
        public string AppointmentTypeIds { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete{ get; set; }
       
    }
    public class V_CompanyMap : myselfFastEntityTypeConfiguration<V_Company>
    {
   
      

    }
}
