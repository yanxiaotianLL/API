using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Jigou_test
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
    }
}
