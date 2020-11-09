using myselfFast.ZFBZ.Core.Domain.Company;
using myselfFast.ZFBZ.Data.ViewEntity;
using System;
using System.Linq;
using myselfFast.Fund.Services;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Common;
namespace myselfFast.ZFBZ.Services.Company
{
    public class CompanyService : BaseService<T_Company>, ICompanyService
    {
        public CompanyService(IRepository<T_Company> tEntityResponsity,
           IDataProvider _dataProvider,
           IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
        }
        /// <summary>
        /// 显示企业信息
        /// </summary>
        /// <param name="companyname"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="state"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public JqGridResult<V_Company> getCompanyList(string companyname, string starttime, string endtime, string state, int pageIndex, int pageSize)
        {
            var stime = string.IsNullOrEmpty(starttime) ? DateTime.Now : Convert.ToDateTime(starttime);
            var dtime = string.IsNullOrEmpty(endtime) ? DateTime.Now : Convert.ToDateTime(endtime);
            string replacesql = @"replace(
		replace(
			replace(
				replace(
					replace(
						replace(
							replace(
								replace(
									replace(
										replace( replace( REPLACE( ',' + a.AppointmentTypes+ ',', ',1,', ',参保企业失业保险费返还,' ), ',2,', ',新职工岗位适应性补贴,' ), ',3,', ',岗位补贴和社会保险补贴,' ),
										',4,',
										',见习补贴,' 
									),
									',6,',
									','',' 
								),
								',5,',
								',一次性培训补贴,' 
							),
							',7,',
							',困难企业失业保险费返还补贴,' 
						),
						',8,',
						',以训稳岗补贴,' 
					),
					',9,',
					',临时性岗位补贴,' 
				),
				',10,',
				',以工代训扩岗补贴,' 
			),
			',11,',
			',以工代训稳岗补贴,' 
		),
		',12,',
		',高精尖产业技能提升培训补贴,' 
	) ";
            var sql = _dbContext.SqlQuery<V_Company>(string.Format(@"SELECT
	t.CreateTime,
	t.CompanyProperty,
	CreditCode,
	CompanyName,
	RegAddress,
	BusinessAddress,
	LegalRepresent,
	ContactPerson,
	ContactPhone,
	ContactEmail,
	CompanyProfile,
	BusinessLicense,
	 substring({0}, 2, len({0}) - 2) AS 'AppointmentTypes',
	0 AS 'SubsidyTypes',
	a.CreateTime AS 'AppointTime',
	'' AS 'Status',
	a.id AS 'AppointId',
	t.id AS 'CompanyId',
	t.IsDelete,
	t.UpdateTime,
	a.Note,
	a.AppointSign,
	t.Trade,
	a.AppointmentTypes 'AppointmentTypeIds',
	s.ChineseName 'AreaName',
	CONVERT ( INT, CONVERT ( nvarchar ( 10 ), ROW_NUMBER ( ) OVER ( ORDER BY t.id ) ) ) AS 'Id' 
FROM
	T_Company t
	LEFT JOIN T_Company_Appointment a ON t.id= a.CompanyId 
	AND a.IsDelete= 0
	LEFT JOIN T_Sys_Dic s ON s.Code= t.AreaCode 
	AND s.DicType= 'PLACE' 
WHERE
	t.IsDelete=0",replacesql));
            var query =sql.Where(t => t.IsDelete == false)
                    .WhereIf(t => t.CompanyName.Contains(companyname), !string.IsNullOrEmpty(companyname))
                    .WhereIf(t => t.AppointTime >= stime, !string.IsNullOrEmpty(starttime))
                    .WhereIf(t => t.AppointTime < dtime, !string.IsNullOrEmpty(endtime))
                    .WhereIf(t => string.IsNullOrEmpty(t.AppointmentTypes), state == "0")
                    .WhereIf(t => !string.IsNullOrEmpty(t.AppointmentTypes), state == "1")
                    .OrderByDescending(t=>t.AppointTime).ThenByDescending(t=>t.CreateTime);
                PagedList<V_Company> page = new PagedList<V_Company>(query, pageIndex, pageSize);
                var jqlist = JqGridResult<V_Company>.Build(page);
                return jqlist;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public T_Company InsertCompany(T_Company company ,out string msg)
        {
            msg = "";
            var selmodel = _tEntityResponsity.Table.Where(t => t.CompanyName == company.CompanyName).FirstOrDefault();
            if (selmodel == null)
            {
               var checkemail= _tEntityResponsity.Table.Where(t => t.ContactEmail == company.ContactEmail).FirstOrDefault();
               if (checkemail!=null)
               {
                   msg = "邮箱已注册";
                   return new T_Company();
               }
                AddEntity(company);

             //   SaveEntity(company);
                var model = _tEntityResponsity.Table.Where(t => t.CompanyName == company.CompanyName).FirstOrDefault();
                return model;
        
            }
            else
            {
                msg = "该企业已注册";
                return new T_Company();
            }
        }

        /// <summary>
        /// 总访问数
        /// </summary>
        /// <returns></returns>
        public int allCount()
        {
            var all = _dbContext.SqlQuery<int>("select  ISNULL(sum(VCount),0)  from T_VistorStatistic where isdelete=0");
       
            return all.Sum();

        }
    }
}
