using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.File.FileServerr
{
    /**********************************************************************************
     *项目名称	：FS.Component.File.FileServerr
     *项目描述  ：
     *类名称    ：myselfFileServerConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : myselfFileServerConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/12 17:13:29
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// fescco文件服务器配置信息
    /// </summary>
    public class myselfFileServerConfiguration
    {
        /// <summary>
        /// 文件服务器路径
        /// </summary>
        public string ServerUrl { get; set; }
        /// <summary>
        /// 对应文件服务器文件路径，或功能模块存储位置:多个，以逗号分隔
        /// </summary>
        public string Channels { get; set; }

    }
    /// <summary>
    /// 对应文件服务器文件路径，或功能模块存储位置
    /// </summary>
    public enum Channel
    {
        MedicalExamin = 0,//入职体检
        EntryInformation = 1,//入职信息
        EntryBackground = 2,//入职后台
        MedicalInsurance =3, //补医保
        FundextPdf = 4 //公积金生成的Pdf
    }
}
