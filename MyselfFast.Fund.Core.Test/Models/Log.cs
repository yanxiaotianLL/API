using System;
using System.Collections.Generic;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string SystemName { get; set; }
        public string ModuleName { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Code { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
    }
}
