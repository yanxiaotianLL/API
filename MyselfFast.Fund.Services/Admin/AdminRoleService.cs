using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core;
using myselfFast.Fund.Services.domain;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminRoleService : BaseService<T_Admin_Role>, IAdminRoleService
    {
        public IAdminRoleDataRolePrivilegeService roleDataPrivilegeService;
        public IAdminRolePrivilegeService rolePrivilegeService;
        public IAdminMenuDataService menuDataService;
        public IAdminMenuDataRolePrivilegeService menuDataRolePrivilegeService;
        public AdminRoleService(IRepository<T_Admin_Role> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext,
            IAdminRoleDataRolePrivilegeService roleDataPrivilegeService, IAdminRolePrivilegeService rolePrivilegeService,
            IAdminMenuDataService menuDataService, IAdminMenuDataRolePrivilegeService menuDataRolePrivilegeService)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.roleDataPrivilegeService = roleDataPrivilegeService;
            this.rolePrivilegeService = rolePrivilegeService;
            this.menuDataService = menuDataService;
            this.menuDataRolePrivilegeService = menuDataRolePrivilegeService;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string AddRole(T_Admin_Role role, T_Admin_Account account, List<int> roleDataIds)
        {
            try
            {
                List<T_Admin_Role> roleList = this._tEntityResponsity.Table.Where(p => p.RoleName == role.RoleName && p.IsDelete == false).ToList(); ;
                if (roleList != null && roleList.Count > 0)
                {
                    return "该角色名称已存在！";
                }
                role.IsDelete = false;
                role.CreateAdmin = account.UserName;
                role.CreateTime = DateTime.Now;
                role.UpdateAdmin = account.UserName;
                //role.UpdateTime = DateTime.Now;
                this.AddEntity(role);
                if (role.Id > 0 && roleDataIds != null && roleDataIds.Count > 0)
                {
                    int roleId = role.Id;
                    foreach (int roleDataId in roleDataIds)
                    {
                        T_Admin_RoleData_RolePrivilege roleRrivilege = new T_Admin_RoleData_RolePrivilege();
                        roleRrivilege.CreateAdmin = account.UserName;
                        roleRrivilege.CreateTime = DateTime.Now;
                        roleRrivilege.IsDelete = false;
                        roleRrivilege.RoleID = roleId;
                        roleRrivilege.RoleDataID = roleDataId;
                        List<T_Admin_RoleData_RolePrivilege> roleRrivilegeList = roleDataPrivilegeService.getRolePrivilege(roleRrivilege);
                        if (roleRrivilegeList == null || roleRrivilegeList.Count <= 0)
                        {
                            roleDataPrivilegeService.addRoleDataRolePrivilege(roleRrivilege);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteRoleById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return "参数不正确";
                }
                T_Admin_Role role = GetRoleById(id);
                if (role == null) return "参数不正确";
                role.IsDelete = true;
                this.UpdateEntity(role);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 根据id获取角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T_Admin_Role GetRoleById(int id)
        {
            return this.GetById(id);
        }

        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string EditRole(T_Admin_Role role, T_Admin_Account account, List<int> roleDataIds)
        {
            try
            {
                if (role == null || role.Id <= 0)
                {
                    return "参数不正确！";
                }
                int roleId = role.Id;
                T_Admin_Role dbRole = GetRoleById(roleId);
                dbRole.RoleName = role.RoleName;
                dbRole.RoleCode = role.RoleCode;
                dbRole.RoleDescription = role.RoleDescription;
                //dbRole.UpdateTime = DateTime.Now;
                dbRole.UpdateAdmin = account.UserName;
                this.UpdateEntity(dbRole);
                if (roleDataIds != null && roleDataIds.Count > 0)
                {
                    List<T_Admin_RoleData_RolePrivilege> dbRoleRrivilegeList = roleDataPrivilegeService.getRolePrivilege(
                        new T_Admin_RoleData_RolePrivilege() { RoleID = roleId });
                    List<int> dbRoleDataIds = new List<int>();
                    List<int> exceptDataIds = new List<int>();
                    if (dbRoleRrivilegeList != null && dbRoleRrivilegeList.Count > 0)
                    {
                        dbRoleDataIds = dbRoleRrivilegeList.Select(p => (int)p.RoleDataID).ToList();
                        exceptDataIds = dbRoleDataIds.Except(roleDataIds).ToList();
                    }
                    if (exceptDataIds != null && exceptDataIds.Count > 0)
                    {
                        foreach (int rowDataId in exceptDataIds)
                        {
                            T_Admin_RoleData_RolePrivilege temp = dbRoleRrivilegeList.Where(p => p.RoleDataID == rowDataId).FirstOrDefault();
                            temp.IsDelete = true;
                            roleDataPrivilegeService.UpdateEntity(temp);
                        }
                    }

                    foreach (int roleDataId in roleDataIds)
                    {
                        T_Admin_RoleData_RolePrivilege roleRrivilege = new T_Admin_RoleData_RolePrivilege();
                        roleRrivilege.CreateAdmin = account.UserName;
                        roleRrivilege.CreateTime = DateTime.Now;
                        roleRrivilege.IsDelete = false;
                        roleRrivilege.RoleID = roleId;
                        roleRrivilege.RoleDataID = roleDataId;
                        List<T_Admin_RoleData_RolePrivilege> roleRrivilegeList = roleDataPrivilegeService.getRolePrivilege(roleRrivilege);
                        if (roleRrivilegeList == null || roleRrivilegeList.Count <= 0)
                        {
                            roleDataPrivilegeService.addRoleDataRolePrivilege(roleRrivilege);
                        }
                    }
                }
                else
                {
                    T_Admin_RoleData_RolePrivilege roleRrivilege = new T_Admin_RoleData_RolePrivilege();
                    roleRrivilege.RoleID = roleId;
                    List<T_Admin_RoleData_RolePrivilege> roleRrivilegeList = roleDataPrivilegeService.getRolePrivilege(roleRrivilege);
                    if (roleRrivilegeList != null || roleRrivilegeList.Count > 0)
                    {
                        foreach (T_Admin_RoleData_RolePrivilege tempRolePrivilege in roleRrivilegeList)
                        {
                            roleRrivilege.IsDelete = true;
                            roleDataPrivilegeService.UpdateEntity(tempRolePrivilege);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public JqGridResult<T_Admin_Role> GetRoleList(string roleName, int page, int rows)
        {
            if (page <= 0) page = 1;
            if (rows <= 10) rows = 10;
            IPagedList<T_Admin_Role> pageList = new PagedList<T_Admin_Role>(_tEntityResponsity.Table.WhereIf(p => p.RoleName.Contains(roleName), !string.IsNullOrWhiteSpace(roleName)).Where(p => p.IsDelete == false), page, rows);
            return JqGridResult<T_Admin_Role>.Build(pageList);
        }

        /// <summary>
        /// 角色授权
        /// </summary>
        /// <param name="menuIds"></param>
        /// <param name="roleId"></param>
        /// <param name="menuDataIds"></param>
        /// <returns></returns>
        public string Auth(List<int> menuIds, int roleId, List<int> menuDataIds, T_Admin_Account account)
        {
            try
            {
                if (menuIds == null || menuIds.Count <= 0) return "参数不正确";
                if (roleId <= 0) return "参数不正确";
                foreach (int menuId in menuIds)
                {
                    //修改
                    List<T_Admin_RolePrivilege> rolePrivilegeList = rolePrivilegeService.GetAdminRolePrivilege(roleId);
                    if (rolePrivilegeList != null && rolePrivilegeList.Count > 0)
                    {
                        List<int> menuIdList = rolePrivilegeList.Select(p => p.MenuID).ToList();
                        menuIdList = menuIdList.Except(menuIds).ToList();
                        if (menuIdList != null && menuIdList.Count > 0)
                        {
                            rolePrivilegeList = rolePrivilegeList.Where(p => menuIdList.Contains(p.MenuID)).ToList();
                            foreach (T_Admin_RolePrivilege item in rolePrivilegeList)
                            {
                                item.IsDelete = true;
                                rolePrivilegeService.UpdateEntity(item);

                                List<T_Admin_MenuData_RolePrivilege> menuRolePriList = menuDataRolePrivilegeService.GetMenuDataRolePrivilege(item.Id, 0);
                                foreach (T_Admin_MenuData_RolePrivilege menuRoleTemp in menuRolePriList)
                                {
                                    menuRoleTemp.IsDelete = true;
                                    menuDataRolePrivilegeService.UpdateEntity(menuRoleTemp);
                                }
                            }
                        }
                    }
                    //新增
                    T_Admin_RolePrivilege rolePrivilege = rolePrivilegeService.GetAdminRolePrivilege(roleId, menuId).FirstOrDefault();
                    if (rolePrivilege == null || rolePrivilege.Id <= 0)
                    {
                        rolePrivilege = new T_Admin_RolePrivilege();
                        rolePrivilege.MenuID = menuId;
                        rolePrivilege.RoleID = roleId;
                        rolePrivilege.IsDelete = false;
                        rolePrivilege.CreateTime = DateTime.Now;
                        rolePrivilege.CreateAdmin = account.UserName;
                        rolePrivilegeService.AddEntity(rolePrivilege);
                    }
                    if (rolePrivilege.Id > 0)
                    {
                        //修改
                        List<T_Admin_MenuData_RolePrivilege> menuRoleRriList = menuDataRolePrivilegeService.GetMenuDataRolePrivilege(rolePrivilege.Id, 0);
                        if (menuRoleRriList != null && menuRoleRriList.Count > 0)
                        {
                            List<int> menuDataIdList = menuRoleRriList.Select(p => p.MenuDataID).Except(menuDataIds).ToList();
                            menuRoleRriList = menuRoleRriList.Where(p => menuDataIdList.Contains(p.MenuDataID)).ToList();
                            foreach (var item in menuRoleRriList)
                            {
                                item.IsDelete = true;
                                menuDataRolePrivilegeService.UpdateEntity(item);
                            }
                        }
                        //新增
                        List<T_Admin_MenuData> menuDataList = menuDataService.GetMenuDataList(1, 200, menuId);
                        if (menuDataIds != null && menuDataIds.Count > 0 && menuDataList != null && menuDataList.Count > 0)
                        {
                            List<int> intersectMenuDataIds = menuDataList.Select(s => s.Id).ToList().Intersect(menuDataIds).ToList();
                            foreach (int menuDataId in intersectMenuDataIds)
                            {
                                //判断是否存在
                                T_Admin_MenuData_RolePrivilege menuRoleData = menuDataRolePrivilegeService.GetMenuDataRolePrivilege(rolePrivilege.Id, menuDataId).FirstOrDefault();
                                if (menuRoleData == null || menuRoleData.Id <= 0)
                                {
                                    menuRoleData = new T_Admin_MenuData_RolePrivilege();
                                    menuRoleData.MenuDataID = menuDataId;
                                    menuRoleData.RolePrivilegeID = rolePrivilege.Id;
                                    menuRoleData.CreateTime = DateTime.Now;
                                    menuRoleData.CreateAdmin = account.UserName;
                                    menuRoleData.IsDelete = false;
                                    menuDataRolePrivilegeService.AddEntity(menuRoleData);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }
    }
}
