using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Project
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string FlsName { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public string Pid { get; set; }
        public int IsChooseCity { get; set; }
        public int IsAction { get; set; }
        public string ContractNum { get; set; }
        public string OurPerson { get; set; }
        public string PeerPerson { get; set; }
        public System.DateTime ContracDate { get; set; }
        public string PackageIds { get; set; }
        public string Packages { get; set; }
        public string Context { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int PType { get; set; }
        public string CardRule { get; set; }
        public int StartPos { get; set; }
        public int EndPos { get; set; }
        public string AllotStart { get; set; }
        public string AllotEnd { get; set; }
        public System.DateTime LStart { get; set; }
        public System.DateTime LEnd { get; set; }
        public int LDays { get; set; }
        public int CreaterId { get; set; }
        public string CreaterName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int EditerId { get; set; }
        public string EditerName { get; set; }
        public System.DateTime EditTime { get; set; }
        public int IsFamily { get; set; }
        public string ProjectNo { get; set; }
        public int Packagetype { get; set; }
        public int CheckType { get; set; }
        public string Pic { get; set; }
        public bool IsIntervention { get; set; }
        public string OtherVerify { get; set; }
        public bool IsDelete { get; set; }
        public string CustTypeName { get; set; }
        public string mnkey { get; set; }
        public string mnpassword { get; set; }
        public int PackageEndTime { get; set; }
        public int PayEndTime { get; set; }
        public decimal PriceMarket { get; set; }
        public decimal PricePromoCode { get; set; }
        public decimal PriceRakeBack { get; set; }
    }
}
