using myselfFast.ZFBZ.Core.Domain.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.ModelExt
{
    public class AppointRequestModel
    {
        /// <summary>
        /// 申请信息
        /// </summary>
        public T_Company_Appointment appoint { get; set; }
        /// <summary>
        /// 填报信息
        /// </summary>
        public List<T_Company_Subsidies> subList { get; set; }
    }
}
