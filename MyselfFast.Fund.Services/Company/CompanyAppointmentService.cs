using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using System;
using System.Linq;

namespace myselfFast.ZFBZ.Services.Company
{
    public class CompanyAppointmentService:BaseService<T_Company_Appointment>, ICompanyAppointmentService
    {
        public CompanyAppointmentService(IRepository<T_Company_Appointment> tEntityResponsity,
           IDataProvider _dataProvider,
           IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
        }
        /// <summary>
        /// 修改备注
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        public void editAppoint(int id,string note)
        {
            var query = _tEntityResponsity.Table.FirstOrDefault(t => t.Id == id);
            if (query != null)
            {
                query.Note = note;
                query.UpdateTime = DateTime.Now;
                UpdateEntity(query);
            } 
        }
    }
}
