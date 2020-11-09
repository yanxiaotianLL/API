using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewSystem.SDK.Entities.Request.FileService;
using NewSystem.SDK.Interfaces;
using System.IO;
using myselfFast.Fund.Core.Common;
using NewSystem.SDK.Factory;

namespace myselfFast.Fund.Services.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void GetErRecordDataByIdTest()
        {
            IFileDownService fileDownService = NewSystemFactory.GetFileDownService();

            GetErRecordDataByIdRequestModel model = new GetErRecordDataByIdRequestModel();
            model.fileId = "684BD00FFA3577B9E053DF4B000A9FF6";
            Stream stream = fileDownService.GetErRecordDataById(model);
            string path = AppDomain.CurrentDomain.BaseDirectory + "/基采-只生数的工期安排.xlsx";
            Stream fileDes = new FileStream(path, FileMode.CreateNew);
            StreamHelper.StreamCopy(stream, fileDes);
        }
    }
}
