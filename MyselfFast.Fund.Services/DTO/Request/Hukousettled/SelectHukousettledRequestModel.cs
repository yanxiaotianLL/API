using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Hukousettled
{
    [Serializable]
    public class SelectHukousettledRequestModel
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        public int State { get; set; }//状态
        public string OrderId { get; set; }//订单编号
        public string ApplyTimeStart { get; set; }//申请日期开始
        public string ApplyTimeEnd { get; set; }//申请日期结束

        public string rangTime { get; set; }//时间类型
        public string startTime { get; set; }//日期开始
        public string endTime { get; set; }//日期结束

        public string CensusRegister { get; set; }//户口状态
        public string RecordState { get; set; }//档案状态
        public string MigrationType { get; set; }//迁移类型

        public string Uniqueno { get; set; }//唯一号
        public string MaritalStatus { get; set; }//婚姻状态
        public string uCname { get; set; }//姓名

        public string uMobile { get; set; }//手机号
        public string uCardId { get; set; }//身份号


    }
}
