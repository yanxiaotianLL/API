using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Coomon
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Coomon
     *项目描述  ：
     *类名称    ：EncryptionTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EncryptionTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-31 10:46:42
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public   class EncryptionTest
    {
        [TestMethod]
        public void TestDecrypt() {
            string strDes = "F76BDC77540526257A1DA843158443ED";
            string key = "key!(*&";

            string str = PasswordHelper.DecodeDES(strDes, key);

            Assert.AreEqual("Hello", str);
        
        }
        [TestMethod]
        public void TestEcrypt()
        {
            //string strDes = "中华人民共和国";
            //string key = "hxdes123";
            string strDes = "dbhZ7*9*^n@p@3@_";
            string key = "!@qwaszx";
            string str = PasswordHelper.EncodeDES(strDes, key);

            //Assert.AreEqual("Hello", str);

        }
        [TestMethod]
        public void TestMd5()
        {
            string password = "180701";
            string md5Pass = EncryptHelper.MD5(password).ToLower();
        }
    }
}
