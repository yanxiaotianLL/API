using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class ApiInputLog
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Region { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string HttpMethod { get; set; }
        public string Sign { get; set; }
        public string OriginalString { get; set; }
        public string Ip { get; set; }
        public System.DateTime RequestTime { get; set; }
        public string RequestContent { get; set; }
        public string ResponseContent { get; set; }
        public int Expire { get; set; }
    }
}
