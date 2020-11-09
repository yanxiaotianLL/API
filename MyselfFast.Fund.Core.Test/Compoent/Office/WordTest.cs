using FescoFast.Fund.Core.Component.Office.word;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Fund.Core.Test.Compoent.Office
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Core.Test.Compoent.Office
     *项目描述  ：
     *类名称    ：WordConvertTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : WordConvertTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-22 0:06:07
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void TestReplace()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "/test.doc";
            string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.doc";
            Dictionary<string,string> dics = new Dictionary<string,string>();
            dics.Add("[<单位名称>]","外企人力网络科技有限公司");
            dics.Add("[<开户行>]","北京招商银行");
            WordHelper.PlaceholderReplace(path, pathSave, dics);
        }
       
        [TestMethod]
        public void TestConvertToPdf()
        {
            string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.doc";
            string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.pdf";
            WordHelper.ConverToPdf(path1, pathSave); 
            
        }
        [TestMethod]
        public void TestConvertToHtml()
        {
            string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "/test.docx";
            string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.html";
            WordHelper.ConverToHtml(path1, pathSave);            
        }
        //[TestMethod]
        //public void ConvertToPics()
        //{
        //    string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "/mysql学习笔记.docx";
        //    string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/";
        //    System.Drawing.Image[] images = WordHelper.ConverToPics(path1,1, 50);
        //    int i = 1;
        //    foreach (var image in images)
        //    {
        //        image.Save(pathSave + i + ".jpg", ImageFormat.Jpeg);
        //        i++;
        //    }
        //}
        [TestMethod]
        public void TestConvertToPic()
        {
            string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "/test.docx";
            string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.jpg";
            WordHelper.ConverToPic(path1, pathSave);
        }
        //[TestMethod]
        //public void ConvertToHtml()
        //{
        //    string path1 = System.AppDomain.CurrentDomain.BaseDirectory + "/test.docx";
        //    string pathSave = System.AppDomain.CurrentDomain.BaseDirectory + "/testsave.html";
        //    WordHelper.ConverToHtml(path1, pathSave);
        //}
    }
}
