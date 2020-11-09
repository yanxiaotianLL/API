using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Jigou
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string OpenTime { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public int ProvinceId { get; set; }
        public string Province { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
        public string CloseDateId { get; set; }
        public string CloseDate { get; set; }
        public int Appnum { get; set; }
        public string Coordinate { get; set; }
        public string RouteMap { get; set; }
        public bool Isdelete { get; set; }
        public int advday { get; set; }
        public int lineday { get; set; }
        public int calbeginday { get; set; }
        public int calendday { get; set; }
        public int Appnum_Ind { get; set; }
        public string Bak { get; set; }
        public int Isupnopay { get; set; }
        public int appnum_male { get; set; }
        public int appnum_female { get; set; }
        public int IsAllowItem { get; set; }
        public int IsAllowOnline { get; set; }
        public string CmCityCode { get; set; }
    }
}
