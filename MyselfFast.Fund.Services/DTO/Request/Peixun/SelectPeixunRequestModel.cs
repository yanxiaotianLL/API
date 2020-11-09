using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Peixun
{
    [Serializable]
    public partial class SelectPeixunRequestModel
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }//课程名称
        public int IsOpen { get; set; }//是否开放
        public string BeginTimeStart { get; set; }//开放时间-起始
        public string BeginTimeEnd { get; set; }//开放时间-结束
        public string LabelId { get; set; }//标签
 
    }
}
