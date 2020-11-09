using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Domain.Hukou;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Hukou
{
    [Serializable]
    public class ResHukouDetailListResponseModel 
    {
        public V_HK_Order_List vHk { get; set; }
        public T_HK_Hokou_Transfer hktran { get; set; }
        public string showNum { get; set; } //是否显示张数
        public List<int> Useageid = new List<int>();
        public List<string> Useage = new List<string>();
        public List<string> UseageNum = new List<string>();
        public string Otherdesc { get; set; }//其他的备注
    }
}
