using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Data;

namespace myselfFast.Component.MsgMobile.qxt
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile.qxt
     *项目描述  ：
     *类名称    ：SendMsgHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SendMsgHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/2/17 14:46:41
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class SendMsgHandler : ISendMsgHandler
    {
        private static object lockObject = new object();
        private static Dictionary<string, string> MesResultDic = new Dictionary<string, string>();
         private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Helo_MsgLog> _Entity;


        public SendMsgHandler(IRepository<T_Helo_MsgLog> Entity, ILoggerProviderFactory iLoggerProviderFactory)
             
        {
            this._Entity = Entity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
        public static Dictionary<string, string> GetMesResultDic()
        {
            if (MesResultDic.Any())
            {
                return MesResultDic;
            }
            else
            {
                lock (lockObject)
                {
                    if (MesResultDic.Any())
                    {
                        return MesResultDic;
                    }
                    else
                    {
                        MesResultDic.Add("00", "提交成功");
                        MesResultDic.Add("1", "参数不完整");
                        MesResultDic.Add("2", "鉴权失败（包括：用户状态不正常、密码错误、用户不存在、地址验证失败，黑户）");
                        MesResultDic.Add("3", "号码数量超出50条");
                        MesResultDic.Add("4", "发送失败");
                        MesResultDic.Add("5", "余额不足");
                        MesResultDic.Add("6", "发送内容含屏蔽词");
                        MesResultDic.Add("7", "短信内容超出350个字数");
                        MesResultDic.Add("72", "内容被审核员屏蔽");
                        MesResultDic.Add("8", "号码列表中没有合法的手机号码（条数限制）");
                        MesResultDic.Add("9", "夜间管理，不允许一次提交超过20个号码");
                        MesResultDic.Add("10", "{txt}不应当出现在提交数据中，请修改【模板类账号】");
                        MesResultDic.Add("11", "模板匹配成功【模板类必审、免审账号】");
                        MesResultDic.Add("12", "未匹配到合适模板，已提交至审核员审核【模板类必审账号】");
                        MesResultDic.Add("13", "未匹配到合适模板，无法下发，请修改【模板类免审账号】");
                        MesResultDic.Add("14", "该账户没有模板【模板类账号】");
                        MesResultDic.Add("15", "操作失败【模板类账号】");

                    }
                }
            }
            return MesResultDic;
        }
        /// <summary>
        /// 根据供应商返回值获取发送状态描述
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool GetResultMessage(string key, ref string msg)
        {
            if (key == "00")
            {
                msg = "";
                return true;
            }
            var result = SendMsgHandler.GetMesResultDic().Single(s => s.Key == key);
            msg = result.Value;
            return false;
        }
        public SendMsgHandler()
        {
            //this.CreateMsgLogEvent += GlobalConfiguration.SendMsgLogFactory.CreaterLog().CreateMsgLog;
            //this.SendEmailHandlerEvent += GlobalConfiguration.SendMsgEmailFactory.CreateEmail().SendEmailHandler;
        }
        public bool SendMsg(string phone, string content)
        {
            string msg = string.Empty;
            return this.SendMsgForResult(phone, content, ref msg);

        }

        public bool SendMsg(string phone, string content, ref string msg)
        {
            return this.SendMsgForResult(phone, content, ref msg);

        }
        [Obsolete("服务商所提供服务已经过期，请不要使用。")]
        public bool SendMsg89(string phone, string content)
        {
            throw new NotImplementedException();
        }
        [Obsolete("服务商所提供服务已经过期，请不要使用。")]
        public bool SendMsg89(string phone, string content, ref string msg)
        {
            throw new NotImplementedException();
        }


        public bool SendMsg(string[] phones, string content)
        {
            bool result = false;
            if (phones != null && phones.Any())
            {
                string resultMsg = string.Empty;
                result = this.SendMsgForResult(string.Join(",", phones), content, ref resultMsg);
            }


            return result;
        }

        public bool SendMsg(string[] phones, string content, ref string msg)
        {

            bool result = false;
            string resultMsg = string.Empty;
            if (phones != null && phones.Any())
            {
                result = this.SendMsgForResult(string.Join(",", phones), content, ref resultMsg);
            }
            msg = resultMsg;
            return result;
        }
        private bool SendMsgForResult(string phone, string content, ref string msg)
        {
            //phone = "17710929606";//测试使用

            SendRequestModel requestModel = this.CreateRequestModel();
            requestModel.phone = phone;
            requestModel.message = content;
            string serverUrl = myselfFast.Component.MsgMobile.GlobalConfiguration.Configuration.ServerUrl;

            requestModel.linkid = Guid.NewGuid().ToString("N").Substring(0, 20);
            serverUrl += this.CreateMsgPameters(requestModel);
            string result = string.Empty;
            bool flag = false;
            try
            {
                result = myselfFast.Fund.Core.Common.HttpHelper.HttpGetString(serverUrl);
                flag = GetResultMessage(result, ref msg);
            }
            catch (Exception ex)
            {
                flag = false;
                msg = ex.Message;
            }
            if (!flag)
            {
                // //如果发送失败,记录到T_HELO_MsgLog,并且发送邮件给zhu.zhi.peng
                GlobalConfiguration.SendMsgEmailFactory.CreateEmail().SendEmailHandler(msg, phone);
            }
            if (GlobalConfiguration.SendMsgLogFactory != null)
                GlobalConfiguration.SendMsgLogFactory.CreaterLog(_Entity, iLoggerProviderFactory).CreateMsgLog(phone, requestModel.linkid, content, msg);
            return flag;
        }

        /// <summary>
        /// 创建请求实体
        /// </summary>
        /// <returns></returns>
        private SendRequestModel CreateRequestModel()
        {
            SendRequestModel model = new SendRequestModel();
            model.username = myselfFast.Component.MsgMobile.GlobalConfiguration.Configuration.Account;
            model.password = myselfFast.Component.MsgMobile.GlobalConfiguration.Configuration.Password;
            model.epid = myselfFast.Component.MsgMobile.GlobalConfiguration.Configuration.TID;
            model.linkid = "";
            model.subcode = "";
            return model;
        }
        /// <summary>
        /// 创建请求参数
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private string CreateMsgPameters(SendRequestModel model)
        {
            StringBuilder paramters = new StringBuilder();
            paramters.Append(string.Format("?{0}={1}&", SendMsgParamters.username, model.username));
            paramters.Append(string.Format("{0}={1}&", SendMsgParamters.password, model.password));
            paramters.Append(string.Format("{0}={1}&", SendMsgParamters.phone, model.phone));
            paramters.Append(string.Format("{0}={1}&", SendMsgParamters.message, HttpUtility.UrlEncode(model.message, Encoding.GetEncoding("gb2312"))));
            paramters.Append(string.Format("{0}={1}&", SendMsgParamters.epid, model.epid));
            paramters.Append(string.Format("{0}={1}&", SendMsgParamters.linkid, model.linkid));
            paramters.Append(string.Format("{0}={1}", SendMsgParamters.subcode, model.subcode));

            return paramters.ToString();
        }

    }
    /// <summary>
    /// 请求参数定义
    /// </summary>
    public class SendMsgParamters
    {
        public const string username = "username";
        public const string password = "password";
        public const string phone = "phone";
        public const string message = "message";
        public const string epid = "epid";
        public const string linkid = "linkid";
        public const string subcode = "subcode";
    }


}
