using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api.Infrastructure.NewSdk
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Api.Infrastructure.NewSdk
	 *项目描述  ：
	 *类名称    ：SdkLogger
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : SdkLogger
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-05-08 17:29:34
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class SdkLogger : NewSystem.SDK.Log.Ilogger
    {
        private static ILogger logger = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(LoggerType.ApiInputLogEntity);
        public void LogOutPut(NewSystem.SDK.Log.LogEntity entity)
        {
            //int expire = (int)entity.CostTime ;
           
            //ApiOutputLogEntity logEntity = new ApiOutputLogEntity(){
            //    AccountName = "",
            //    Expire = expire,
            //    RequestContent = entity.OutIn,
            //    ResponseContent = entity.OutPut,
            //    RequestTime = entity.CreateTime

            //};
            //logger.Info(this,entity);

            string strIn = string.Format("\r\n============新系统接口:Call-Begin==============\r\n输入：{0}\r\n请求地址：{1}\r\n请求发起时间{2}\r\n开始时间:{3}\r\n结束时间:{4}\r\n耗时:{5}\r\n=============Call-End=============", entity.OutIn, entity.OutPut, entity.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"), entity.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), entity.EndTime.ToString("yyyy-MM-dd HH:mm:ss"), entity.CostTime >= 2000 ? entity.CostTime.ToString() + "(超时)" : entity.CostTime.ToString());
            logger.Info(this, strIn);
            
        }
    }
    public class SDKLoggerFactory : NewSystem.SDK.Log.ILoggerFactory
    {


        public NewSystem.SDK.Log.Ilogger CreateLoggerInstance()
        {
            return new SdkLogger();
        }
    }
}