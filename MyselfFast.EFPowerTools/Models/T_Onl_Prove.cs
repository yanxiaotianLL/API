using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Onl_Prove
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int Fesid { get; set; }
        public int ScId { get; set; }
        public string ScName { get; set; }
        public string BsName { get; set; }
        public string FName { get; set; }
        public System.DateTime GenDate { get; set; }
        public int PayTypeid { get; set; }
        public string PayTypeName { get; set; }
        public System.DateTime PayDate { get; set; }
        public string PayAccount { get; set; }
        public decimal PayMoney { get; set; }
        public System.DateTime AccDate { get; set; }
        public int AddrId { get; set; }
        public string AddrStr { get; set; }
        public string AddrStrTag { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public int PiaoState { get; set; }
        public string PiaoTitle { get; set; }
        public string PiaoUse { get; set; }
        public bool PrintState { get; set; }
        public System.DateTime PrintDate { get; set; }
        public string Tails { get; set; }
        public string CancelMemo { get; set; }
        public string Kno { get; set; }
        public string Alipayno { get; set; }
        public int PiaoType { get; set; }
        public string PiaoNumber { get; set; }
    }
}
