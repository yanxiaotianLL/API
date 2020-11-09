using myselfFast.Fund.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Coomon
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Coomon
     *项目描述  ：
     *类名称    ：BarCodeGeneratorTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : BarCodeGeneratorTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 16:52:27
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public class BarCodeGeneratorTest
    {
        /// <summary>
        /// 条形码生成测试
        /// </summary>
        [TestMethod]
        public void TestBarCodeGerertor()
        {
            string code = "12345678";
            string fileName = System.AppDomain.CurrentDomain.BaseDirectory + "/BarCodeGeneratorTest.jpg";
            using (Image image = BarCodeGenerator.GenerateBarCodeBitmap(code))
            {
                image.Save(fileName, ImageFormat.Jpeg);
            }

        }
        /// <summary>
        /// 条形码生成测试
        /// </summary>
        [TestMethod]
        public void TestBarCodeGerertorCusomerSize()
        {
            string code = "12345678";
            string fileName = System.AppDomain.CurrentDomain.BaseDirectory + "/TestBarCodeGerertorCusomerSize.jpg";
            using (Image image = BarCodeGenerator.GenerateBarCodeBitmap(code,270,150))
            {
                image.Save(fileName, ImageFormat.Jpeg);
            }

        }
    }
}
