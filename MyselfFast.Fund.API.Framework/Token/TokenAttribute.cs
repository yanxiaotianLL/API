
using myselfFast.Fund.API.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using myselfFast.Fund.API.Framework.Extensition;

namespace myselfFast.Fund.API.Framework.Token
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：标识该Action为获取Token的请求入口，并验证用户信息生成Token
     *类名称    ：TokenAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:50:17
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [AttributeUsage(AttributeTargets.Method,AllowMultiple=false)]
    public sealed class TokenActionAttribute : ActionFilterAttribute
    {
        private AuthenticationManger authenticationManger = new AuthenticationManger();
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //请求参数为空，非法请求
            if (actionContext.ActionArguments.Keys.Any(p => p == "ClientId") &&
                actionContext.ActionArguments.Keys.Any(p => p == "ClientSecret"))
            {
            }
            else
            {
                actionContext.CreateResponseResult<TokenModel>("非法请求，请正确发送你的身份数据。", false);
                actionContext.Response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                
                return;
            }
            //参数获取
            string appid = actionContext.ActionArguments["ClientId"].ToString();
            string secret = actionContext.ActionArguments["ClientSecret"].ToString();

            //数据验证
            //从用户认证标识存储设备获取用户认证信息
            var clientCredentials = WebApiConfiguration.CreateInstance()
                .ClientCredentialsProviderFactory.CreateClientCredentialsProviderInstance()
                .GetByClientId(appid);
            //判断用户认证识别凭据是否存在
            if (clientCredentials == null)
            {
                actionContext.CreateResponseResult<TokenModel>("ClientId不正确，请正确发送你的身份数据。", false);
                actionContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                return;
            }
            //用户密钥验证
            if (clientCredentials.ClientSecret != secret)
            {
                actionContext.CreateResponseResult<TokenModel>("ClientSecret验证失败，请正确发送你的身份数据。", false);
                actionContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                return;
            }
            //Token身份生成
          //  TokenModel tokenModel = new TokenModel(){ ClientId = clientCredentials.ClientId, ContentKey = clientCredentials.ContentKey, Expires_In= WebApiConfiguration.CreateInstance().DefaultExpireTime, IsUseContentKey = clientCredentials.IsUseContentKey, Token_Type = TokenType.Bearer};
          //  tokenModel.Access_Token = authenticationManger.CreateToken(clientCredentials);
          //  //发送token给用户
          //  WebApiConfiguration.CreateInstance().TokenContainer.AddToken(tokenModel);
           
          //  actionContext.Response = actionContext.ActionDescriptor.ResultConverter.Convert
          //(actionContext.ControllerContext, (new ResponseBase<TokenModel> { Data = tokenModel, Message = "认证成功", Success = true }));
            return;
         }
    }
}
