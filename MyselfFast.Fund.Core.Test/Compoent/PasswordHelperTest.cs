using myselfFast.Fund.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Compoent
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Compoent
     *项目描述  ：
     *类名称    ：PasswordHelperTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : PasswordHelperTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-22 11:32:27
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public class PasswordHelperTest
    {
        [TestMethod]
        public void TestEncodeDES()
        {
            
            string pass =  PasswordHelper.DecodeDES("C7C26A256B66713A1E84FC857DD1FD76", PasswordHelper.defaultPass);


            string val = PasswordHelper.EncodeDES("北京捷越联合信息咨询有限公司-全国-低档@服务模版：-企业比例：合肥市:12/郑州市:12/济南市:12/青岛市:12210495", pass);

            string sval = PasswordHelper.DecodeDES(val, pass);
            //C7C26A256B66713A1E84FC857DD1FD76
            //string str = PasswordHelper.EncodeDES("!@qwaszx", "@wsxzaq1");
            string strPass = PasswordHelper.EncodeDES("1qazxsw23edc", pass);
            //Assert.IsNotNull(str);
        }
        //public void Test
    }
}
