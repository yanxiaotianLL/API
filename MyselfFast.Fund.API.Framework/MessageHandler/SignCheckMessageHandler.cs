using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.API.Framework.Models;
using LitJson2;
using myselfFast.Component.Cache;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Configuration;
using myselfFast.Fund.Core.Common.Extensions;


namespace myselfFast.Fund.API.Framework.MessageHandler
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler
     *项目描述  ：
     *类名称    ：SignCheckMessageHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SignCheckMessageHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/30 23:41:39
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class SignCheckMessageHandler : DelegatingHandler
    {
        private ServiceAccount serviceAccount = null;
       
        protected  override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {

                //判断验证方式
                if (request.GetAuthorizationMode() != AuthorizationMode.APPACCOUNT)
                {
                    return base.SendAsync(request, cancellationToken);
                }
          
                List<KeyValuePair<string, string>> paramDic = new List<KeyValuePair<string, string>>();
                string content = string.Empty;
                //获取参数
                #region 判断请求类型
                //判断请求类型
                if (request.Method == HttpMethod.Get)
                {
                    var query = request.GetQueryNameValuePairs();


                    #region AppAccount参数校验
                    if (query.Any(a => a.Key == SignParamter.AppAccount) && SignCheckHelp(query.Single(s => s.Key == SignParamter.AppAccount).Value, request))
                    {
                        paramDic.Add(request.GetQueryNameValuePairs().GetParamter(SignParamter.AppAccount));

                    }
                    else
                    {
                        var message = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的AppAccount参数！",
                            Success = false
                        });
                        message.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(message);



                    }
                    #endregion
                    #region Noncestr参数校验
                    //Noncestr参数校验
                    if (query.Any(a => a.Key == SignParamter.Noncestr))
                    {
                        paramDic.Add(request.GetQueryNameValuePairs().GetParamter(SignParamter.Noncestr));
                    }
                    else
                    {
                        var result = request.CreateResponse(request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的Noncestr参数！",
                            Success = false
                        }));
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);

                    }
                    #endregion
                    #region Timestamp参数校验
                    //Noncestr参数校验
                    if (query.Any(a => a.Key == SignParamter.Timestamp))
                    {
                        var timestamp = request.GetQueryNameValuePairs().GetParamter(SignParamter.Timestamp);
                        paramDic.Add(timestamp);
                        //判断时间戳是否有效
                        DateTime dt = TimeStampHelper.StampToDateTime(timestamp.Value);
                        //5分钟有效期 if ((DateTime.Now.AddMinutes(-500) <= dt) && (dt <= DateTime.Now))
                        //if ((DateTime.Now.AddMinutes(-500) <= dt) && (dt <= DateTime.Now))
                        if (true)
                        {
                        }
                        else
                        {
                            var result = request.CreateResponse(new ResponseBase<object>()
                            {
                                Code = "1",
                                Data = null,
                                Message = "请求过期！",
                                Success = false
                            });
                            result.StatusCode = HttpStatusCode.OK;
                            return Task.FromResult<HttpResponseMessage>(result);
                        }


                    }
                    else
                    {
                        var result = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的Timestamp参数！",
                            Success = false
                        });
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);

                    }
                    #endregion
                    #region jsonParam参数如果存在，则进行sign校验，如果不存在则不进行
                    //JsonParam参数如果存在，则进行sign校验，如果不存在则不进行
                    if (query.Any(a => a.Key == SignParamter.JsonParam))
                    {
                        JsonParamtersToSign(paramDic, request.GetQueryNameValuePairs().GetParamter(SignParamter.JsonParam).Value.EncodingToUtf8());
                    }
                    #endregion
                    #region Sign参数校验
                    //签名计算检查
                    if (query.Any(a => a.Key == SignParamter.Signature))
                    {
                        var signature = request.GetQueryNameValuePairs().GetParamter(SignParamter.Signature);
                        request.Properties[SignParamter.Signature] = signature.Value;
                        //签名计算
                        var signatureStr = SignCreate(paramDic);

                        //签名正确
                        if (signature.Value == signatureStr)
                        {

                        }
                        else
                        {

                            var result = request.CreateResponse(new ResponseBase<object>()
                            {
                                Code = "2",
                                Data = null,
                                Message = "Signature签名不正确！",
                                Success = false
                            });
                            result.StatusCode = HttpStatusCode.OK;

                            return Task.FromResult<HttpResponseMessage>(result);
                        }
                    }
                    else
                    {
                        var result = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "2",
                            Data = null,
                            Message = "Signature签名不正确！",
                            Success = false
                        });
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);

                    }
                    #endregion



                    #region 请求参数重构，重放

                    if (query.Any(a => a.Key == SignParamter.JsonParam))
                    {
                        JsonData jsonParamData =
                        JsonMapper.ToObject(request.GetQueryNameValuePairs().GetParamter(SignParamter.JsonParam).Value.EncodingToUtf8());
                        string paramters = string.Empty;
                        //重新构造url参数
                        foreach (var p in jsonParamData.Keys)
                        {
                            if (string.IsNullOrEmpty(paramters))
                            {
                                paramters += string.Format("?{0}={1}", p, jsonParamData[p].ToString());

                            }
                            else
                            {
                                paramters += string.Format("&{0}={1}", p, jsonParamData[p].ToString());
                            }
                            request.Properties[p] = jsonParamData[p].ToString();
                        }
                        request.RequestUri = new Uri(request.RequestUri.ToString().Split('?')[0] + paramters);
                        request.Properties["Model_Paramters"] =
                            request.GetQueryNameValuePairs().GetParamter(SignParamter.JsonParam).Value;
                    }
                    else
                    {
                        request.RequestUri = new Uri(request.RequestUri.ToString().Split('?')[0]);

                    }
                    #endregion

                }

                #endregion
                #region 请求了类型为post参数获取
                else if (request.Method == HttpMethod.Post)
                {
                    content = request.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    JsonData jd = JsonMapper.ToObject(content);


                    #region AppAccount

                    if (jd.Keys.Contains(SignParamter.AppAccount) && SignCheckHelp(jd[SignParamter.AppAccount].ToString().ToUpper(), request))
                    {
                        paramDic.Add(new KeyValuePair<string, string>(SignParamter.AppAccount,
                            jd[SignParamter.AppAccount].ToString()));

                    }
                    else
                    {
                        var message = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的AppAccount参数！",
                            Success = false
                        });
                        message.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(message);
                    }

                    #endregion

                    #region Noncestr

                    if (jd.Keys.Contains(SignParamter.Noncestr))
                    {
                        paramDic.Add(new KeyValuePair<string, string>(SignParamter.Noncestr,
                            jd[SignParamter.Noncestr].ToString()));
                    }
                    else
                    {
                        var result = request.CreateResponse(request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的Noncestr参数！",
                            Success = false
                        }));
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);
                    }

                    #endregion

                    #region Timestamp参数校验

                    if (jd.Keys.Contains(SignParamter.Timestamp))
                    {
                        //判断时间戳是否有效
                        DateTime dt = TimeStampHelper.StampToDateTime(jd[SignParamter.Timestamp].ToString());
                        //5分钟有效期  if ((DateTime.Now.AddMinutes(-500) <= dt) && (dt <= DateTime.Now))
                        //if ((DateTime.Now.AddMinutes(-500) <= dt) && (dt <= DateTime.Now))
                        if (true)
                        {
                        }
                        else
                        {
                            var result = request.CreateResponse(new ResponseBase<object>()
                            {
                                Code = "1",
                                Data = null,
                                Message = "请求过期！",
                                Success = false
                            });
                            result.StatusCode = HttpStatusCode.OK;
                            return Task.FromResult<HttpResponseMessage>(result);
                        }


                        paramDic.Add(new KeyValuePair<string, string>(SignParamter.Timestamp,
                            jd[SignParamter.Timestamp].ToString()));
                    }
                    else
                    {
                        var result = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "1",
                            Data = null,
                            Message = "请传递正确的Timestamp参数！",
                            Success = false
                        });
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);

                    }

                    #endregion

                    #region 签名参数构造

                    //参数构造
                    if (jd.Keys.Contains(SignParamter.JsonParam))
                    {
                        JsonParamtersToSign(paramDic, jd[SignParamter.JsonParam]);
                    }

                    #region Sign参数校验

                    //签名计算检查
                    if (jd.Keys.Contains(SignParamter.Signature))
                    {
                        var signature = jd[SignParamter.Signature].ToString();
                        //签名计算
                        var signatureStr = SignCreate(paramDic);
                        request.Properties[SignParamter.Signature] = signature;
                        //签名正确
                        if (signature.ToString() == signatureStr)
                        {

                        }
                        else
                        {
                            var result = request.CreateResponse(new ResponseBase<object>()
                            {
                                Code = "2",
                                Data = null,
                                Message = "Signature签名不正确！",
                                Success = false
                            });
                            result.StatusCode = HttpStatusCode.OK;
                            return Task.FromResult<HttpResponseMessage>(result);
                        }
                    }
                    else
                    {
                        var result = request.CreateResponse(new ResponseBase<object>()
                        {
                            Code = "2",
                            Data = null,
                            Message = "Signature签名不正确！",
                            Success = false
                        });
                        result.StatusCode = HttpStatusCode.OK;
                        return Task.FromResult<HttpResponseMessage>(result);

                    }

                    #endregion

                    #endregion
                    if (jd.Keys.Contains(SignParamter.JsonParam) && !string.IsNullOrEmpty(jd[SignParamter.JsonParam].ToJson()))
                    {

                        request.Properties["Model_Paramters"] = jd[SignParamter.JsonParam].ToJson();
                    }


                }
                #endregion
                #region 其它谓词类型
                else
                {
                    var message = request.CreateResponse(new ResponseBase<object>()
                    {
                        Code = "1",
                        Data = null,
                        Message = string.Format("暂不支持{0}谓词", request.Method),
                        Success = false
                    });
                    message.StatusCode = HttpStatusCode.OK;
                    return Task.FromResult<HttpResponseMessage>(message);
                }
                #endregion                   

          
            return  base.SendAsync(request, cancellationToken);
            
        }
        /// <summary>
        /// 签名所需参数部分处理
        /// </summary>
        /// <param name="paramDic"></param>
        /// <param name="jsonParamter"></param>
        private void JsonParamtersToSign(List<KeyValuePair<string, string>> paramDic,string jsonParamter)
        {
            JsonData jd = JsonMapper.ToObject(jsonParamter);

            foreach (var p in jd.Keys)
            {
                var v = jd[p];
                if (v.IsObject || v.IsArray)
                {
                   //暂时不在签名中使用
                }
                else
                {
                    paramDic.Add(new KeyValuePair<string, string>(p, jd[p].ToString()));
                }
            }
        }
        /// <summary>
        /// 签名所需参数部分处理
        /// </summary>
        /// <param name="paramDic"></param>
        /// <param name="jsonParamter"></param>
        private void JsonParamtersToSign(List<KeyValuePair<string, string>> paramDic, JsonData jsonParamter)
        {
            JsonData jd = jsonParamter;

            foreach (var p in jd.Keys)
            {
                var v = jd[p];
                if (v.IsObject || v.IsArray)
                {
                    //暂时不在签名中使用
                }
                else
                {
                    paramDic.Add(new KeyValuePair<string, string>(p, jd[p].ToString()));
                }
            }
        }
        /// <summary>
        /// 签名计算
        /// </summary>
        /// <param name="paramDic"></param>
        /// <returns></returns>
        private string SignCreate(List<KeyValuePair<string, string>> paramDic)
        {
            paramDic = paramDic.Where(p => !string.IsNullOrEmpty(p.Value)).ToList();
            paramDic.Sort((a, b) => String.Compare(a.Key, b.Key, false));
            var text = string.Concat(paramDic.Select(p => string.Concat(p.Key, p.Value)));
            var sign = EncryptHelperTwo.MD5One((serviceAccount.Appsecret + text.EncodingToUtf8()).EncodingToUtf8()).ToLower();
            
            return sign;
        }

       
        /// <summary>
        /// 校验辅助方法之AppAccount校验
        /// </summary>
        private bool SignCheckHelp(string appAccount, HttpRequestMessage request)
        {
            var accounts = FSGlobalConfiguration.Configuration.ServiceAccountConfiguration.ServiceAccounts;
            if (accounts != null && accounts.Any(a=>a.AppId.ToUpper() == appAccount.ToUpper()))
            {
                serviceAccount = accounts.Single(s => s.AppId.ToUpper() == appAccount.ToUpper());
                request.Properties[SignParamter.AppAccount] = serviceAccount;
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// 计算签名所需要的参数
    /// </summary>
    public class SignParamter
    {
        /// <summary>
        /// 签名
        /// </summary>
        public const string Signature = "sign";
        /// <summary>
        /// 随机串
        /// </summary>
        public const string Noncestr = "noncestr";
        /// <summary>
        /// 时间戳
        /// </summary>
        public const string Timestamp = "timestamp";
        /// <summary>
        /// 客户端名称
        /// </summary>
        public const string AppAccount = "appaccount";
        /// <summary>
        /// 参数值
        /// </summary>
        public const string JsonParam = "jsonParam";



    }
    
   
}
