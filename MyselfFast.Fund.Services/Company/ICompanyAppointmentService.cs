using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Company
{
    public interface ICompanyAppointmentService:IBaseService<T_Company_Appointment>
    {
         /// <summary>
        /// 修改备注
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        void editAppoint(int id, string note);
    }
}
