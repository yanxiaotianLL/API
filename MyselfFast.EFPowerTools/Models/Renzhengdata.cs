using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Renzhengdata
    {
        public int Id { get; set; }
        public string Khid { get; set; }
        public string Khname { get; set; }
        public string Real_Name { get; set; }
        public string Employee_Name { get; set; }
        public string Zjnumber { get; set; }
        public string Employee_Code { get; set; }
        public string Type { get; set; }
        public string Contact_Tel1 { get; set; }
        public string Contact_Tel2 { get; set; }
        public string E_Mail { get; set; }
        public System.DateTime Indate { get; set; }
        public string State { get; set; }
    }
}
