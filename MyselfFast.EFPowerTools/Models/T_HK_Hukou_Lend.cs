using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_HK_Hukou_Lend
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public string Uniqueno { get; set; }
        public int Addressid { get; set; }
        public string Usage { get; set; }
        public string Otherdesc { get; set; }
        public int Copydoc { get; set; }
        public int Originaldoc { get; set; }
        public int Firstpage { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Remark { get; set; }
        public int Fesid { get; set; }
        public System.DateTime Optime { get; set; }
        public System.DateTime Committime { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public int Isback { get; set; }
        public bool Isdelete { get; set; }
        public int Flag { get; set; }
        public int Frequency { get; set; }
        public string HuKouPateern { get; set; }
        public string Trackingnumber { get; set; }
        public System.DateTime EndRenewaltime { get; set; }
        public string Trackingcompany { get; set; }
        public string Cause { get; set; }
        public int Firstcopy { get; set; }
    }
}
