using myselfFast.Fund.Core;
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
    public partial class ResPeixunCozInfoResponseModel : T_Trn_CozInfo
    {
        public string LabelIdsName { get; set; }//标签名称

    }
}
