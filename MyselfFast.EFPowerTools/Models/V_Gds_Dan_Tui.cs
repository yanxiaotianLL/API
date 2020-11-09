using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Gds_Dan_Tui
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int Fesid { get; set; }
        public int Orderid { get; set; }
        public string OrderNo { get; set; }
        public decimal Mny { get; set; }
        public System.DateTime GenDate { get; set; }
        public int State { get; set; }
        public int Planid { get; set; }
        public int Hno { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Usedname { get; set; }
        public string Gno { get; set; }
        public string CardId { get; set; }
        public string Mobile { get; set; }
    }
}
