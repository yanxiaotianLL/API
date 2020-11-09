using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminDepartService : IBaseService<T_Admin_Depart>
    {
        List<T_Admin_Depart> GetParentDepartList(string scode);
        List<T_Admin_Depart> GetChildDepartList(string scode);
        List<T_Admin_Depart> GetAllDepartList();
        string AddDepart(T_Admin_Depart Depart, T_Admin_Account account);
        string DeleteDepart(int DepartId);
        T_Admin_Depart GetDepartInfoById(int DepartId);
        string EditDepart(T_Admin_Depart Depart);
        List<T_Admin_Depart> GetDepartInfoByName(String DepartName);
    }
}
