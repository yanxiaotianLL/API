using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Tb_User_Ext6_20161129
    {
        public int Id { get; set; }
        public int Idx { get; set; }
        public string 缴费人员类别 { get; set; }
        public System.DateTime 四险缴费截止日期 { get; set; }
        public System.DateTime 医疗保险缴费截止日期 { get; set; }
        public System.DateTime 住房公积金缴费截止日期 { get; set; }
        public bool 是否缴纳过生育保险 { get; set; }
        public bool 是否已领取社会保障卡 { get; set; }
    }
}
