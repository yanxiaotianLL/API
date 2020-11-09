using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDebugTool.Model
{
    /**********************************************************************************
     *项目名称	：WebApiDebugTool.Model
     *项目描述  ：
     *类名称    ：WebApiToolConfigModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : WebApiToolConfigModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/22 17:05:06
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class WebApiToolConfigModel
    {
        public List<AppToolConfigModel> AppConfigModels { get; set; }
        public List<NewSystemAppToolConfigModel> NewSystemConfigModels { get; set; }

        public AppToolConfigModel CurrentAppConfigModel { get; set; }
        public NewSystemAppToolConfigModel CurrentNewSystemConfigModel { get; set; }
    }

    public class AppToolConfigModel
    {
        public int ID { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string DefaultUrls { get; set; }
        public int IsChecked { get; set; }
        public string Remark { get; set; }
    }


    public class NewSystemAppToolConfigModel
    {
        public int ID { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string DefaultUrls { get; set; }
        public bool IsChecked { get; set; }
        public bool IsUseToken { get; set; }
        public string Remark { get; set; }
    }
   
}
