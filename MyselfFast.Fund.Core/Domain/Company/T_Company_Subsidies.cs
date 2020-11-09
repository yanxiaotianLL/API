using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Core.Domain.Company
{
    public class T_Company_Subsidies : BaseEntity
    {
        /// <summary>
        /// 预约类型
        /// </summary>
        public int AppointmentId { get; set; }
        public int CompanyId { get; set; }
        /// <summary>
        /// 补贴类型
        /// </summary>
        public int SubsidyTypes { get; set; }
        public string Info { get; set; }
        /// <summary>
        /// 预约批次标识
        /// </summary>
        public string AppointSign { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
