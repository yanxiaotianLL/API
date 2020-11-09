using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Peixun
{
    [Serializable]
    public partial class SelectYuangongRequestModel
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PersonId { get; set; }
        public int Hno { get; set; }
        public string Yewubu { get; set; }

        public string CreateTimeStart { get; set; }
        public string CreateTimeEnd { get; set; }
        public int IsActive { get; set; }
        public string LabelId { get; set; }
        public string busiCustName { get; set; }
        
    }
}
