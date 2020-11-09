using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class T_Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string StaticUrl { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string AdminName { get; set; }
        public bool IsDelete { get; set; }
    }
}
