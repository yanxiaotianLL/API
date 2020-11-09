using FescoFast.Collect.Api.Models.Request.Test;
using FescoFast.Collect.Api.Models.Response;
using FescoFast.Collect.API.Framework.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FescoFast.Collect.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private IArticle articleService;
        public ValuesController(IArticle articleService)
        {
            this.articleService = articleService;
        }
        [ActionName("nono")]
        // GET api/values
        public ResponseBase<object> Get()
        {
            return new ResponseBase<object>{
                Data =new string[] { "value1", "value2" },
                Code = "0",
                Message = "成功",
                Success = true
            } ;
        }


        // POST api/values
        [HttpPost]
        public ResponseBase<TestResponse> Update(TestRequest request)
        {
            return new ResponseBase<TestResponse>
            {
                Data = new TestResponse{
                 Name = request.Name,
                 Age = request.Age
                },
                Code = "0",
                Message = "成功",
                Success = true
            };
        }

       
    }
}
