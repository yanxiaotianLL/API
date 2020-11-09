using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_Userverify
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public bool Verify { get; set; }
        public bool SafeVerify { get; set; }
        public bool MoreVerify { get; set; }
        public string CompanVerify { get; set; }
        public string minzu { get; set; }
        public string xueli { get; set; }
        public string zhengzhimianmao { get; set; }
        public string hukousuozaidi { get; set; }
        public string dangansuozaidi { get; set; }
        public string jishuzhicheng { get; set; }
        public string xiangxidizhi { get; set; }
        public string youzhengbianma { get; set; }
        public string yidongdianhua { get; set; }
        public string shebaorenyuanleibie { get; set; }
        public string zaipaizhuangtai { get; set; }
        public string shangshebianhao { get; set; }
        public string fuzhubianhao { get; set; }
        public string suozaigongsi { get; set; }
        public string zhiwu { get; set; }
        public string suoshuyewubu { get; set; }
        public string yewuyuan { get; set; }
        public string yewuyuanPhone { get; set; }
        public string yewuyuanEmail { get; set; }
        public string fuwuhetongyouxiaoqi { get; set; }
        public string rudangshijian { get; set; }
        public System.DateTime shoucicanjiagongzuoshijian { get; set; }
        public string xianyouzhiwujibie { get; set; }
        public string zhiyezige { get; set; }
        public System.DateTime jianligongjijinshijian { get; set; }
        public string suozhudangzhibu { get; set; }
        public bool wentifuli { get; set; }
        public bool duzifei { get; set; }
    }
}
