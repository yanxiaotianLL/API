using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：NewSystem.SDK.Common
     *项目描述  ：
     *类名称    ：StreamHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : StreamHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-29 13:25:28
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class StreamHelper
    {
        /// <summary>
        /// 将一个流内容拷贝到另一个流，并执行关闭动作
        /// </summary>
        /// <param name="streamSource">源</param>
        /// <param name="streamDes">目标</param>
        public static void StreamCopy(Stream streamSource,Stream streamDes)
        {
            if (streamSource == null)
            {
                throw new ArgumentNullException("streamSource不能为空");
            }
            if (streamDes == null)
            {
                throw new ArgumentNullException("streamDes不能为空");
            }

            int bufferSize = 2048;
            byte[] buffer = new byte[bufferSize];
            int readCount = 0;
            try
            {
                while ((readCount = streamSource.Read(buffer, 0, bufferSize)) > 0)
                {
                    streamDes.Write(buffer, 0, readCount);
                }
            }
            catch(Exception ex){
                
            }
            finally
            {
                streamDes.Flush();
                streamDes.Close();
                streamDes.Dispose();
                streamSource.Close();
                streamSource.Dispose();
            }
          
           
        }
        public static void StreamCopy(Stream streamSource, string  fileDes)
        {
            if (streamSource == null)
            {
                throw new ArgumentNullException("streamSource不能为空");
            }
            if (string.IsNullOrEmpty(fileDes))
            {
                throw new ArgumentNullException("fileDes不能为空");
            }
            Stream streamDes = new FileStream(fileDes, FileMode.Create);
            int bufferSize = 2048;
            byte[] buffer = new byte[bufferSize];
            int readCount = 0;
            try
            {
                while ((readCount = streamSource.Read(buffer, 0, bufferSize)) > 0)
                {
                    streamDes.Write(buffer, 0, readCount);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                streamDes.Flush();
                streamDes.Close();
                streamDes.Dispose();
                streamSource.Close();
                streamSource.Dispose();
            }


        }
    }
}
