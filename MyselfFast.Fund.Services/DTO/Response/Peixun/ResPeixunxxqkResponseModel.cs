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
    public class ResPeixunxxqkResponseModel : T_Trn_StuRec
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime BeginTime { get; set; }
        public int Credit { get; set; }
        public decimal SumMin { get; set; }
        public string Cname { get; set; }
        public int Hno { get; set; }
        public string busiCustName { get; set; }

        public int FesUserCardType { get; set; }
        public string FesUserCardId { get; set; }

        public string Yewubu { get; set; }
    }
}
