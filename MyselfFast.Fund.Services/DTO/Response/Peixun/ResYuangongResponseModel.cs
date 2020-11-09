using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Domain.Peixun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Peixun
{
    [Serializable]
    public class ResYuangongResponseModel : T_Trn_Stu
    {
        private string _Cname="";
        public string Cname
        {
            get { return _Cname; }
            set { _Cname = value; }
        }

        private int _Hno=0;
        public int Hno
        {
            get { return _Hno; }
            set { _Hno = value; }
        }

        private string _busiCustName = "无";
        public string busiCustName
        {
            get { return _busiCustName; }
            set { _busiCustName = value; }
        }

        private int _FesUserCardType=0;
        public int FesUserCardType
        {
            get { return _FesUserCardType; }
            set { _FesUserCardType = value; }
        }


        private string _FesUserCardId = "";
        public string FesUserCardId
        {
            get { return _FesUserCardId; }
            set { _FesUserCardId = value; }
        }

        private string _Yewubu = "";
        public string Yewubu
        {
            get { return _Yewubu; }
            set { _Yewubu = value; }
        }

        private string _LconBeginDate = "";
        public string LconBeginDate
        {
            get { return _LconBeginDate; }
            set { _LconBeginDate = value; }
        }

        private string _OrderSta = "";
        public string OrderSta
        {
            get { return _OrderSta; }
            set { _OrderSta = value; }
        }
        private string _LabelIdsName = "";
        public string LabelIdsName//标签名称
        {
            get { return _LabelIdsName; }
            set { _LabelIdsName = value; }
        }
    }
}
