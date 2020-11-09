using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Mdc_Medical
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Fesid { get; set; }
        public string OrderId { get; set; }
        public string Hospital { get; set; }
        public System.DateTime Jzrq { get; set; }
        public string Jbmc { get; set; }
        public string Sjzs { get; set; }
        public string Sbje { get; set; }
        public string Djzs { get; set; }
        public int FyLx { get; set; }
        public string Znjzdd { get; set; }
        public int Mtype { get; set; }
        public int Jsuan { get; set; }
        public int Istjsb { get; set; }
        public System.DateTime Idate { get; set; }
        public string PeiCname { get; set; }
        public string PeiCid { get; set; }
        public string PeiSex { get; set; }
        public System.DateTime PeiBirthday { get; set; }
        public string SCname { get; set; }
        public string SCid { get; set; }
        public string SSex { get; set; }
        public System.DateTime SBirthday { get; set; }
        public int Mstatus { get; set; }
        public string Psbak { get; set; }
        public int Isdel { get; set; }
    }
}
