using myselfFast.Fund.API.Framework.ClientCredentials;
using myselfFast.Fund.API.Framework.Token;
using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Token
     *项目描述  ：
     *类名称    ：TokenConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 22:14:34
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class WebApiConfiguration
    {
         /// <summary>
        /// 单例模式实现
        /// </summary>
        private WebApiConfiguration() { }

        private volatile static WebApiConfiguration _instance = null;

        private static readonly object LockHelper = new object();
        public static WebApiConfiguration CreateInstance()
        {
            if (_instance == null)
            {
                lock (LockHelper)
                {
                    if (_instance == null)
                        _instance = new WebApiConfiguration();
                }
            }
            return _instance;
        }
        private ITokenContainer _tokenContainer;
        /// <summary>
        /// token对象存储容器
        /// </summary>
        public ITokenContainer TokenContainer
        {
            get
            {
                if(_tokenContainer == null)
                {
                    _tokenContainer = DefaultTokenContainer.CreateInstance();
                }
                return _tokenContainer;
            }
            set { _tokenContainer = value; }
        }

        private ILogger _logger;
        /// <summary>
        /// 日志记录对象
        /// </summary>
        public ILogger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LoggerProviderFactory.CreateLogger();
                }
                return _logger;
            }
            set { _logger = value; }
        }

        private bool _logSwitch;
        /// <summary>
        /// 是否开启日志记录功能
        /// </summary>
        public bool LogSwitch
        {
            get { return _logSwitch; }
            set { _logSwitch = value; }
        }
        /// <summary>
        /// 默认token过期时间
        /// </summary>
        private TimeSpan _defaultExpireTime = TimeSpan.FromMilliseconds(1000 * 60 * 60);
        public TimeSpan DefaultExpireTime {
            get { return _defaultExpireTime; }
            set { _defaultExpireTime = value; }
        }

        private IClientCredentialsProviderFactory _clientCredentialsProviderFactory;
         /// <summary>
        /// 客户端身份存储查询提供程序
        /// </summary>
        public IClientCredentialsProviderFactory ClientCredentialsProviderFactory
        {
            get
            {
                if (_clientCredentialsProviderFactory == null)
                {
                    _clientCredentialsProviderFactory = new DefaultClientCredentialsProviderFactory();
                }
                return _clientCredentialsProviderFactory;
            }
             set { _clientCredentialsProviderFactory = value; }
        }
        /// <summary>
        /// 用户默认认证凭证存储
        /// </summary>
        public IList<ClientCredentialsModel> ClientCredentialsModelStore = new List<ClientCredentialsModel>();
    }
}
