using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class V_Gds_Base
    {
        public int Id { get; set; }
        public int Gysid { get; set; }
        public string GysJiancheng { get; set; }
        public string Gysname { get; set; }
        public string Numbers { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string AliasName { get; set; }
        public string AliasEName { get; set; }
        public string Stand { get; set; }
        public string Model { get; set; }
        public string Product { get; set; }
        public string Ysname { get; set; }
        public string Ysname2 { get; set; }
        public long Mcid { get; set; }
        public string Mcname { get; set; }
        public string Jianj { get; set; }
        public bool Tuiable { get; set; }
        public string Attention { get; set; }
        public int State { get; set; }
        public bool IsUsed { get; set; }
        public System.DateTime PubToFescoDate { get; set; }
        public System.DateTime DownFromGysDate { get; set; }
        public System.DateTime SelectByFescoDate { get; set; }
        public int Askdelete { get; set; }
        public string AskCause { get; set; }
        public string AskBack { get; set; }
        public System.DateTime DownFromFescoDate { get; set; }
        public bool Isduty { get; set; }
        public int Dutyid { get; set; }
        public string CardRule { get; set; }
        public string DealRule { get; set; }
        public int SpType { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Ext3 { get; set; }
        public string Ext4 { get; set; }
        public string Ext5 { get; set; }
        public string Ext6 { get; set; }
        public bool IsMonyOnly { get; set; }
        public bool IsSendByGys { get; set; }
        public System.DateTime Lmtdate { get; set; }
        public System.DateTime Hitstime { get; set; }
        public long Hits { get; set; }
        public int SoHuId { get; set; }
        public int Belongto { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
    }
}
