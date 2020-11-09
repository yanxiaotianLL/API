using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Whole
    {
        public int Id { get; set; }
        public string Danno { get; set; }
        public int Fid { get; set; }
        public int Busid { get; set; }
        public int Fesid { get; set; }
        public string Addr { get; set; }
        public string Postcode { get; set; }
        public int Paytype { get; set; }
        public decimal SelPart { get; set; }
        public decimal ExtPart { get; set; }
        public decimal Decfei { get; set; }
        public decimal Mnypay { get; set; }
        public int Danstate { get; set; }
        public System.DateTime Dandate { get; set; }
        public System.DateTime Paydate { get; set; }
        public System.DateTime ConfirmDate { get; set; }
        public string Bankseq { get; set; }
        public bool FapiaoState { get; set; }
        public string Fapiaotitle { get; set; }
        public string Fapiaotype { get; set; }
        public int PiaoType { get; set; }
        public string PiaoNumber { get; set; }
        public string Aplman { get; set; }
        public string Aplgonghao { get; set; }
        public int Planid { get; set; }
        public string PlanName { get; set; }
        public int Hno { get; set; }
        public long Interid { get; set; }
        public int Source { get; set; }
        public string Fname { get; set; }
        public string Script { get; set; }
        public string Yewubu { get; set; }
        public string YewubuUser { get; set; }
        public int GdsTs { get; set; }
        public string Bak { get; set; }
    }
}
