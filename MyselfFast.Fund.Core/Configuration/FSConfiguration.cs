using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Configuration
{
    /**********************************************************************************
     *项目名称	：FS.Config
     *项目描述  ：
     *类名称    ：FSConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FSConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/18 21:49:04
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class FSConfiguration
    {
        /// <summary>
        /// 体检部分设计配置
        /// </summary>
        public ExaminConfiguration ExaminConfiguration { get; set; }
        /// <summary>
        /// 移动端相关配置
        /// </summary>
        public PhoneConfiguration PhoneConfiguration { get; set; }
        /// <summary>
        /// 公积金模块配置
        /// </summary>
        public FundextRentConfiguration FundextRentConfiguration { get; set; }
        /// <summary>
        /// 补医保pdfurl下载路径配置
        /// </summary>
        public string MedicalInsurancePdfUrl { get; set; }
        /// <summary>
        /// 服务用户账户、权限配置
        /// </summary>
        public ServiceAccountConfiguration ServiceAccountConfiguration { get; set; }
        /// <summary>
        /// 公积金pdf获取html路径配置
        /// </summary>
        public string FundextGetPdfHtml { get; set; }
        /// <summary>
        /// 补医保后台获取实赔金额接口地址
        /// </summary>
        public string MedicalBackgroundInterfaceUrl { get; set; }
        /// <summary>
        /// 微信服务获取token地址
        /// </summary>
        public string WeiXinTokenServiceUrl { get; set; }
        //补医保用微信模版小模版ID
        public string WeiXinBybTempleateId { get; set; }

    }
}
