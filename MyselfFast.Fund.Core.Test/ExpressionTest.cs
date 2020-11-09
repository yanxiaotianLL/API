
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Fund.Core.Test
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Core.Test
     *项目描述  ：
     *类名称    ：ExpressionTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ExpressionTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-14 14:44:02
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class ExpressionTest
    {
       
            
        public string ExTest(Expression<Func<D_JC_Address, string>> ex,D_JC_Address address)
        {
            var compile =  ex.Compile();
            string addressName = compile.Invoke(address);
            return addressName;
        }
        [TestMethod]
        public void TestExpression()
        {
            D_JC_Address address = new D_JC_Address
            {
                area_name = "大背景大北京"
            };
            string addressName = ExTest(t => t.area_name, address);
            try
            {


            }
            catch { }


        }
    }
}
