using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.HuKouSettled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

namespace myselfFast.Fund.Services.DTO.Response.Hukousettled
{
    [Serializable]
    public class SelectHukousettledResponseModel : T_HK_Settled_Info 
    {
        #region 员工信息
        public int Uniqueno { get; set; }
        public string uCname { get; set; }
        public string uCardId { get; set; }
        public string uMobile { get; set; }
        public string uEmail { get; set; }
        public string busiCustName { get; set; }
        #endregion 

        #region 身份证信息
        public int cardInfoId { get; set; }
        public int cardInfoFesId { get; set; }
        public int cardInfoHno { get; set; }
        public string CradName { get; set; }
        public string CardId { get; set; }
        public string CardGender { get; set; }
        public string CardNation { get; set; }
        public string CardBirth { get; set; }
        public string Cardvalidate { get; set; }
        public string CardAuthority { get; set; }
        public System.DateTime cardInfoCreateDate { get; set; }
        public System.DateTime cardInfoUpdateDate { get; set; }
        public int cardInfoStatus { get; set; }
        public string CardAddress { get; set; }
        public decimal OcrLevel { get; set; }
        public string ElecMatSource { get; set; }
        public string CardNationValue { get; set; }
        #endregion 

        #region 材料信息

        public List<fileData> fileDt = new List<fileData>();
        public string ImageList { get; set; }

        public List<fileData> KuaidifileDt = new List<fileData>();
        public string KuaidiImageList { get; set; }
        #endregion

        public string IsHKSettledGuangLi { get; set; }


    }

    //材料
    public class  fileData
    {
        public String fileId { get; set; }
        public String img { get; set; }
        public String type { get; set; }

        public String typename { get; set; }

        public HttpResponseMessage response = new HttpResponseMessage();
    }
    public class jsonParamsDate
    {
        public string FileType { get; set; }
        public string[] Reason =new string[20];
    }
}
