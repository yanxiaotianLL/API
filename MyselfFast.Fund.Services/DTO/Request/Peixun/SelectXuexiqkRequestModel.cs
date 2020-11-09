using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Peixun
{
    [Serializable]
    public partial class SelectXuexiqkRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }//课程名称
        public string busiCustName { get; set; }
        public string Yewubu { get; set; }
        public string BeginTimeStart { get; set; }//开放时间-起始
        public string BeginTimeEnd { get; set; }//开放时间-结束
        public int IsFinish { get; set; }
 
    }
}
