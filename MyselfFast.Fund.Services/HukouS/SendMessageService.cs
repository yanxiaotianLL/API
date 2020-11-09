using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using myselfFast.Component.MsgMobile;

namespace myselfFast.Fund.Services.HukouS
{
    public class SendMessageService : BaseService<V_HK_Order_List>,ISendMessageService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;

        ISendMsgHandler _sendMsgHandler;
        public SendMessageService(IRepository<V_HK_Order_List> tEntityResponsity
            //, IRepository<T_HK_Order> tVEntityResponsity
            , ISendMsgHandler sendMsgHandler
            ,IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._sendMsgHandler = sendMsgHandler; 
        }

        public string  SendMessage(string tId)
        {
            string result = string.Empty;
            try
            {

            #region 【确认归还-发现超期】短信发送
 
            int orderid=Utils.ToInt(tId);
            string mobile1 = "";
            string msgContent1 = ("您已超期归还户口卡原件，请于2天内登录员工自助服务平台或myself服务微信公众号，查看户口卡借阅历史记录，在对应的超期订单后点击超期退款申请按钮，申请退还押金。").Trim();
            V_HK_Order_List tV= _tEntityResponsity.Table.Where(p => p.Id == orderid).ToList().First();
            if (tV != null && tV.Id > 0)
            {
                if (tV.uMobile != "")
                {
                    mobile1 = Encryption.IsEncrypted(tV.uMobile) ?  Encryption.Decrypt(tV.uMobile):"";
                }
                else
                {
                    mobile1 = tV.Pone;
                }
            }
            if (mobile1 != "")
            {
                bool v = _sendMsgHandler.SendMsg(mobile1, msgContent1);

                _logger.Info(this.GetType(), "集体户口【确认归还-发现超期】短信发送记录：" + mobile1 + "内容：" + msgContent1);
                if (v == false)
                {
                    result = "短信发送失败！";
                }
            }
            else
            {
                result = "手机号不存在，短信发送失败！";
            }
            
            #endregion
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        public string SendMessageQianchu(string tId)
        {
            string result = string.Empty;
            try
            {

                #region 【确认归还-发现超期】短信发送

                int orderid = Utils.ToInt(tId);
                string mobile1 = "";
                string msgContent1 = ("您的户口已迁出，请于2天内登录员工自助服务平台或myself服务微信公众号，查看户口迁出记录，在对应的超期订单后点击超期退款申请按钮，申请退还押金。").Trim();
                V_HK_Order_List tV = _tEntityResponsity.Table.Where(p => p.Id == orderid).ToList().First();
                if (tV != null && tV.Id > 0)
                {
                    if ( tV.uMobile != "")
                    {
                        mobile1 = Encryption.IsEncrypted(tV.uMobile) ? Encryption.Decrypt(tV.uMobile) : "";
                    }
                    else
                    {
                        mobile1 = tV.Pone;
                    }
                }
                if (mobile1 != "")
                {
                    bool v = _sendMsgHandler.SendMsg(mobile1, msgContent1);

                    _logger.Info(this.GetType(), "集体户口【确认归还-发现超期】短信发送记录：" + mobile1 + "内容：" + msgContent1);
                    if (v == false)
                    {
                        result = "短信发送失败！";
                    }
                }
                else
                {
                    result = "手机号不存在，短信发送失败！";
                }
                
                #endregion
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
