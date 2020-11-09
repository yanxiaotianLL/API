using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Core.Domain.Company
{
    public class T_Company_Appointment : BaseEntity
    {
        public int  CompanyId { get; set; }
        /// <summary>
        /// 预约类型
        /// </summary>
        public string AppointmentTypes { get; set; }
        /// <summary>
        /// 预约批次标识
        /// </summary>
        public string AppointSign { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Note { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
