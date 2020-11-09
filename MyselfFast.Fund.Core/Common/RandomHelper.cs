using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：RandomHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : RandomHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-22 14:07:41
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class RandomHelper
    {
        #region 生成随机字符码
        public static string CreateVerifyCode(int codeLen)
        {

            // 自定义随机码字符串序列(使用逗号分隔)
            string codeSerial = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] arr = codeSerial.Split(',');

            string code = "";

            int randValue = -1;

            Random rand = new Random(unchecked((int)DateTime.Now.Ticks));

            for (int i = 0; i < codeLen; i++)
            {
                randValue = rand.Next(0, arr.Length - 1);

                code += arr[randValue];
            }

            return code;
        }
        #endregion
    }
}
