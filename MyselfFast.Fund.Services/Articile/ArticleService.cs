﻿using FescoFast.Collect.Core.Data;
using FescoFast.Collect.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Collect.Services.Articile
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Services.Articile
     *项目描述  ：
     *类名称    ：ArticleService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ArticleService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-14 12:43:01
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class ArticleService : IArticle
    {
        private IRepository<T_Article> articleResponsity;
        public ArticleService(IRepository<T_Article> articleResponsity)
        {
            this.articleResponsity = articleResponsity;
        }
        public void TestEf()
        {
            var articles = articleResponsity.Table.Select(s => s).ToList();
        }
    }
}
