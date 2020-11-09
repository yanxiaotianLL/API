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
    public class ResPeixunLableResponseModel : T_Trn_Label
    {
        public string isclosable { get; set; }//该便签是否可删除

    }
}
