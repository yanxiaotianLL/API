using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Hukousettled
{
    [Serializable]
    public class SpecdayResponseModel
    {
        public dayshowType[] dayshowlist = new dayshowType[365];
    }
    public class dayshowType
    {
        public DateTime dangtian { get; set; }
        public string Type { get; set; }
        public int AnumALL { get; set; }
        public int  AnumYu { get; set; }
        public int AnumNow { get; set; }
        public int BnumALL { get; set; }
        public int BnumYu { get; set; }
        public int BnumNow { get; set; }
        public int CnumALL { get; set; }
        public int CnumYu { get; set; }
        public int CnumNow { get; set; }
        public int DnumALL { get; set; }
        public int DnumYu { get; set; }
        public int DnumNow { get; set; }
        public int EnumALL { get; set; }
        public int EnumYu { get; set; }
        public int EnumNow { get; set; }
        
    }
    public class dicShowday
    {
        public string LocalShowDay { get; set; }    //本市户籍显示天数
        public string NonLocalShowDay { get; set; } //外地户籍显示天数
        public string DefaultShowDay { get; set; }  //默认每天预约人数
    }
    public class shijianduan
    {
        public string tmeStart { get; set; }
        public string tmeEnd { get; set; }
    }
    public class P_HK_getNumNow
    {
        public int id { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }

    }
    public class P_HK_getNumALL 
    {
        public int id { get; set; }
        public int SpecType { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }

    }
}
