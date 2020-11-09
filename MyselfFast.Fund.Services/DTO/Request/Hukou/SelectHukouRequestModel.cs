using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Hukou
{
    [Serializable]
    public partial class SelectHukouRequestModel
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        public int Transtype { get; set; }//办理业务
        public string OrderFrom { get; set; }//办理渠道
        public string ApplyTimeStart { get; set; }//申请日期开始
        public string ApplyTimeEnd { get; set; }//申请日期结束
        public int State { get; set; }//订单状态
        public int OrderType{ get; set; }//订单类型 1快递订单，2电子邮件订单
        public int PiaoState { get; set; }//是否开发票
        public int PrintState { get; set; }
        public string Uniqueno { get; set; }//唯一号
        public string uCname { get; set; }//姓名
        public string OrderNo { get; set; }//订单号
        public string uCardId { get; set; }//身份号
    }
}
