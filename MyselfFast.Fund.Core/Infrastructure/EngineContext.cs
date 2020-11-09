using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Autofac;


namespace myselfFast.Fund.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FS.Component.Infrastructure
     *项目描述  ：
     *类名称    ：EngineContext
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EngineContext
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-10 15:49:33
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class EngineContext
    {
        
        #region Methods

        /// <summary>
        /// Initializes a static instance of the Nop factory.
        /// </summary>
        /// <param name="forceRecreate">Creates a new factory instance even though the factory has been previously initialized.</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Initialize(bool forceRecreate)
        {
            if (Singleton<IEngine>.Instance == null || forceRecreate)
            {
                
                Singleton<IEngine>.Instance = new myselfServiceEngine();           
                
                Singleton<IEngine>.Instance.Initialize();
            }
            return Singleton<IEngine>.Instance;
        }

        /// <summary>
        /// Sets the static engine instance to the supplied engine. Use this method to supply your own engine implementation.
        /// </summary>
        /// <param name="engine">The engine to use.</param>
        /// <remarks>Only use this method if you know what you're doing.</remarks>
        public static void Replace(IEngine engine)
        {
            Singleton<IEngine>.Instance = engine;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the singleton Nop engine used to access Nop services.
        /// </summary>
        public static IEngine Current
        {
            get
            {
                //if (Singleton<IEngine>.Instance == null)
                //{
                //    Initialize(false);
                //}
                return Singleton<IEngine>.Instance;
            }
        }

        #endregion
    }
   
}

