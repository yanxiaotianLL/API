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
     *类名称    ：ExaminConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ExaminConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/18 16:14:00
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 体检功能部分相关配置
    /// </summary>
    public class ExaminConfiguration
    {
        /// <summary>
        /// 爱康接口服务地址
        /// </summary>
        public  string ConstAiKangUrl{get;set;}
        /// <summary>
        /// 爱康接口版本号
        /// </summary>
        public  string ConstAiKangVersion  {get;set;}
        /// <summary>
        /// 爱康男性套餐
        /// </summary>
        public string ConstAiKangPackageMale { get; set; }
        /// <summary>
        /// 爱康女性套餐
        /// </summary>
        public string ConstAiKangPackageFemale { get; set; }
        /// <summary>
        /// 瀚思维康接口服务地址
        /// </summary>
        public string ConstHswkUrl { get; set; }
        /// <summary>
        /// 瀚思维康接口公钥
        /// </summary>
        public string ConstHswkSign { get; set; }
        /// <summary>
        /// 瑞慈接口用户
        /// </summary>
        public  string ConstRuiCionlyNo {get;set;}
        /// <summary>
        /// 瑞慈接口密码
        /// </summary>
        public string ConstRuiCiPassword { get; set; }
        /// <summary>
        /// 慈铭接口用户名
        /// </summary>
        public string ConstCiMingVerifyUser { get; set; }
        /// <summary>
        /// 慈铭接口校验密码
        /// </summary>
        public string ConstCiMingVerifyPassword { get; set; }
        /// <summary>
        /// 裕合接口服务地址 裕和端口8083是测试的，正式的是8081
        /// </summary>
        public string ConstYuHeUrl { get; set; }
        /// <summary>
        /// 排期开始时间
        /// </summary>
        public string ConstYuHeStartTime { get; set; }
        /// <summary>
        /// 美年服务器地址
        /// </summary>
        public string ConstMnUrl { get; set; }
        ///// <summary>
        ///// 美年用户
        ///// </summary>
        //public string ConstMnAppkey { get; set; }
        ///// <summary>
        ///// 美年接口密码
        ///// </summary>
        //public string ConstMnPwd { get; set; }
        /// <summary>
        /// 怡健殿服务地址
        /// </summary>
        public string ConstYjdUrl { get; set; }
        /// <summary>
        /// 怡健殿密码
        /// </summary>
        public string ConstYjdPwd { get; set; }
        /// <summary>
        /// 怡健殿唯一号
        /// </summary>
        public string ConstYjdOnlyCode { get; set; }

        /// <summary>
        /// 套餐说明
        /// </summary>
        public string PackageDesc { get; set; }
        /// <summary>
        /// 公立医院协和类数组
        /// </summary>
        public string ConstGlXieHeArry { get; set; }
        /// <summary>
        /// 协和医院允许预约男性个数
        /// </summary>
        public int ConstGlXieHeMale { get; set; }
        /// <summary>
        /// 协和医院允许预约女性个数
        /// </summary>
        public int ConstGlXieHeFemale { get; set; }
        /// <summary>
        /// 微信体检前端Url
        /// </summary>
        public string WeChatExamineFrontUrl { get; set; }
        /// <summary>
        /// 微信接口 URL
        /// </summary>
        public string WeChatDefaultUrls { get; set; }
        /// <summary>
        /// 微信接口  TempId
        /// </summary>
        public string WeChatTempId { get; set; }

        //Api 接口地址
        public string ApiSdkUrl { get; set; }
 
    }
}
