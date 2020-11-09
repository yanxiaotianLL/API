using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminRoleDataService : BaseService<T_Admin_RoleData>, IAdminRoleDataService
    {
        public AdminRoleDataService(IRepository<T_Admin_RoleData> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public JqGridResult<T_Admin_RoleData> GetRoleDataList(int page, int rows)
        {
            IPagedList<T_Admin_RoleData> pagedList = new PagedList<T_Admin_RoleData>(_tEntityResponsity.Table.Where(p => p.IsDelete == false), page, rows);
            return JqGridResult<T_Admin_RoleData>.Build(pagedList);
        }

        /// <summary>
        /// 添加角色权限
        /// </summary>
        /// <param name="roleData"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string AddRoleData(T_Admin_RoleData roleData, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                roleData.CreateAdmin = account.UserName;
                roleData.CreateTime = DateTime.Now;
                roleData.IsDelete = false;
                this.AddEntity(roleData);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        /// <summary>
        /// 修改角色权限
        /// </summary>
        /// <param name="roleData"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string EditRoleData(T_Admin_RoleData roleData, T_Admin_Account account)
        {
            try
            {
                if (roleData == null || roleData.Id <= 0)
                {
                    return "参数不正确！";
                }
                T_Admin_RoleData dbRoleData = GetRoleDataById(roleData.Id);
                dbRoleData.DataKey = roleData.DataKey;
                dbRoleData.DataValue = roleData.DataValue;
                this.UpdateEntity(dbRoleData);
            }catch(Exception e){
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 删除角色权限
        /// </summary>
        /// <param name="roleData"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string DeleteRoleData(int id)
        {
            string result = string.Empty;
            try
            {
                if (id <= 0)
                {
                    return "参数不正确！";
                }
                T_Admin_RoleData roleData = GetRoleDataById(id);
                roleData.IsDelete = true;
                this.UpdateEntity(roleData);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        /// <summary>
        /// 获取角色权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T_Admin_RoleData GetRoleDataById(int id)
        {
            return this.GetById(id);
        }
    }
}
