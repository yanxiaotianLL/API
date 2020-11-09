using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminDepartService : BaseService<T_Admin_Depart>, IAdminDepartService
    {
        public AdminDepartService(IRepository<T_Admin_Depart> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }

        //获取顶层部门
        public List<T_Admin_Depart> GetParentDepartList(string scode)
        {
            List<T_Admin_Depart> DepartList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false && p.ParentID == 0 ).ToList();
            return DepartList;
        }

        //获取非顶层部门
        public List<T_Admin_Depart> GetChildDepartList(string scode)
        {
            List<T_Admin_Depart> DepartList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false && p.ParentID != 0).ToList();
            return DepartList;
        }

        //获取所有部门
        public List<T_Admin_Depart> GetAllDepartList()
        {
            List<T_Admin_Depart> DepartList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false).ToList();
            return DepartList;
        }

        //添加菜单
        public string AddDepart(T_Admin_Depart Depart, T_Admin_Account account)
        {
            try
            {
                List<T_Admin_Depart> DepartList = GetAllDepartList();
                int? parentId = Depart.ParentID;
                Depart.CreateAdmin = account.UserName;
                Depart.UpdateAdmin = account.UserName;
                Depart.CreateTime = DateTime.Now;
                //Depart.UpdateTime = DateTime.Now;
                Depart.SortValue = DepartList.Count + 1;
                Depart.IsDelete = false;
                Depart.IsLeaf = true;
                if (parentId == 0)
                {
                    List<T_Admin_Depart> parentDepartList = DepartList.Where(p => p.ParentID == 0).ToList();
                    int count = parentDepartList.Count() + 1;
                    Depart.DepartCode = count + "" + count + count + count;
                }
                else
                {
                    T_Admin_Depart tempDepart = DepartList.Where(p => p.Id == parentId).FirstOrDefault();
                    List<T_Admin_Depart> parentTempDepartList = DepartList.Where(p => p.ParentID == parentId).ToList();
                    string DepartCode = (parentTempDepartList.Count() + 1).ToString().PadLeft(4, '0');
                    Depart.DepartCode = tempDepart.DepartCode + "-" + DepartCode;
                    //更新父节点为目录节点
                    T_Admin_Depart parentDepart = this.GetById((int)parentId);
                    parentDepart.IsLeaf = false;
                    this.UpdateEntity(parentDepart);
                }
                this.AddEntity(Depart);

                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //删除菜单
        public string DeleteDepart(int departId)
        {
            try
            {
                if (departId <= 0) return "部门id不能为空!";

                T_Admin_Depart depart = this.GetById(departId);

                if (depart == null) return "该部门不存在!";

                if (depart.IsLeaf == true)
                {
                    depart.IsDelete = true;
                    this.UpdateEntity(depart);
                }
                else
                {
                    List<T_Admin_Depart> departList = this.GetAllDepartList();
                    if (departList == null || departList.Count == 0) return "未获取到部门列表!";

                    List<T_Admin_Depart> departChildList = departList.Where(p => p.DepartCode.Contains(depart.DepartCode)).ToList();
                    if (departChildList != null && departChildList.Count > 0)
                    {
                        foreach (T_Admin_Depart departTemp in departChildList)
                        {
                            departTemp.IsDelete = true;
                            this.UpdateEntity(departTemp);
                        }
                    }
                    depart.IsDelete = true;
                    this.DeleteEntity(depart);
                }
                //判断该父节点上是否还存在其他子节点
                int parentId = (int)depart.ParentID;
                List<T_Admin_Depart> list = this.GetAllDepartList();
                if (list != null && list.Count > 0)
                {
                    List<T_Admin_Depart> childlist = list.Where(p => p.ParentID == parentId).ToList();
                    if (childlist == null || childlist.Count == 0)
                    {
                        T_Admin_Depart parentDepart = this.GetById(parentId);
                        if (parentDepart != null)
                        {
                            parentDepart.IsLeaf = true;
                            this.UpdateEntity(parentDepart);
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

        //根据菜单id获取菜单信息
        public T_Admin_Depart GetDepartInfoById(int DepartId)
        {
            if (DepartId <= 0)
            {
                return null;
            }
            return this.GetById(DepartId);
        }

        //修改菜单
        public string EditDepart(T_Admin_Depart depart)
        {
            try
            {
                if (depart == null) return "参数不正确！";
                T_Admin_Depart dbDepart = this.GetById(depart.Id);
                dbDepart.DepartName = depart.DepartName;
                dbDepart.DepartDescription = depart.DepartDescription;
                dbDepart.DepartLeader = depart.DepartLeader;
                dbDepart.LeaderEmail = depart.LeaderEmail;
                //dbDepart.UpdateTime = DateTime.Now;
                this.UpdateEntity(dbDepart);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        //根据菜单名称获取菜单信息
        public List<T_Admin_Depart> GetDepartInfoByName(String DepartName)
        {
            return _tEntityResponsity.Table.Where(p => p.DepartName.Contains(DepartName)).ToList();
        }
       
    }
}
