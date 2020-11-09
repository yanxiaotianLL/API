using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApiDebugTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //配置文件初始化

            WebApiDebugTool.Configs.FSGlobalConfiguration.ConfigInitialization();
            Application.Run(new Main());


        }
    }
}
