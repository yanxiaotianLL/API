using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminMenuDataService : BaseService<T_Admin_MenuData>, IAdminMenuDataService
    {
        IAdminMenuService adminMenuService;
        public AdminMenuDataService(IRepository<T_Admin_MenuData> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext
            , IAdminMenuService adminMenuService)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.adminMenuService = adminMenuService;
        }

        //分页获取列表
        public JqGridResult<T_Admin_MenuData> GetMenuDataList(int page, int rows, string MenuName)
        {
            JqGridResult<T_Admin_MenuData> jqGridResult = new JqGridResult<T_Admin_MenuData>();
            if (page <= 0) page = 1;
            if (rows < 10) rows = 10;

            IPagedList<T_Admin_MenuData> pageList = null;
            if (string.IsNullOrWhiteSpace(MenuName))
            {
                pageList = new PagedList<T_Admin_MenuData>(_tEntityResponsity.Table.Where(p => p.IsDelete == false), page, rows);
            }
            else
            {
                List<T_Admin_Menu> adminMenuList = adminMenuService.GetMenuInfoByName(MenuName);
                if (adminMenuList != null && adminMenuList.Count > 0)
                {
                    List<int> idList = adminMenuList.Select(p => p.Id).ToList();
                    pageList = new PagedList<T_Admin_MenuData>(_tEntityResponsity.Table.Where(s => idList.Contains(s.MenuID)).Where(p => p.IsDelete == false), page, rows);
                }
            }
            if (pageList != null)
            {
                jqGridResult.rows = pageList as List<T_Admin_MenuData>;
                jqGridResult.page = pageList.PageIndex;
                jqGridResult.total = pageList.TotalPages;
                jqGridResult.records = pageList.TotalCount;
            }
            return jqGridResult;
        }

        //添加菜单功能全集
        public string AddMenuData(T_Admin_MenuData menuData, T_Admin_Account account)
        {
            try
            {
                menuData.CreateAdmin = account.UserName;
                menuData.CreateTime = DateTime.Now;
                menuData.IsDelete = false;
                menuData.UpdateAdmin = account.UserName;
                //menuData.UpdateTime = DateTime.Now;
                this.AddEntity(menuData);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        //删除菜单功能全集
        public string DeleteMenuDataById(int id)
        {
            int res = this.DeleteEntitysByIds(new[] { id });
            if (res <= 0)
            {
                return "操作失败";
            }
            return string.Empty;
        }


        public List<T_Admin_MenuData> GetMenuDataList(int page, int rows, int menuId)
        {
            var pageList = new PagedList<T_Admin_MenuData>(_tEntityResponsity.Table.WhereIf(p => p.MenuID == menuId, menuId > 0).Where(p => p.IsDelete == false), page, rows);
            return pageList as List<T_Admin_MenuData>;
        }



        
    }
}
