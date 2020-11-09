using myselfFast.ZFBZ.Core.Domain.Sys;
using myselfFast.Component.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using myselfFast.Fund.Services;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Common;
namespace myselfFast.ZFBZ.Services.Sys
{
    public class SysDicService : BaseService<T_Sys_Dic>, ISysDicService
    {
        private ICacheStorage _cacheStorage;

        private string cachePre = "sysDic_";

        public SysDicService(IRepository<T_Sys_Dic> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            _cacheStorage = CacheProviderFactory.CreateCacheProvider(CacheType.InMemery);
        }

        /// <summary>
        /// 根据Id查询中文名称
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        public string ChineseName(int Id)
        {
            string result = string.Empty;
            T_Sys_Dic dic = _tEntityResponsity.GetById(Id);
            if (dic != null)
            {
                result = dic.ChineseName;
            }
            return result;
        }
        public string ChineseName(string Code)
        {
            T_Sys_Dic dic = _tEntityResponsity.Table.Where(w => w.Code == Code).FirstOrDefault();
            return dic.ChineseName;
        }

        /// <summary>
        /// 根据中文名称获取Code
        /// </summary>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        public string GetCode(string chineseName)
        {
            string result = string.Empty;
            string[] name = chineseName.Split(',');
            var Id = _tEntityResponsity.Table.Where(w => name.Contains(w.ChineseName) && w.ParentId != 0)
                .Where(w => w.DicType == "Trade")
                .ToList();
            if (Id != null && Id.Count > 0)
            {
                foreach (var sys in Id)
                {
                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        result += "," + sys.Code.ToString();
                    }
                    else
                    {
                        result += sys.Code.ToString();
                    }
                }
            }
            return "," + result + ",";
        }

        /// <summary>
        /// 获取省
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> ProvinceList()
        {
            string key = cachePre + "provience";

            //根据键值查找缓存中数据，如果没有再进行数据库查询
            if (_cacheStorage.Exists(key))
            {
                return _cacheStorage.Get<List<T_Sys_Dic>>(key).Value;
            }

            List<T_Sys_Dic> province = _tEntityResponsity.Table.Where(w => w.ParentId == 0 && w.DicType == "PLACE").ToList();

            _cacheStorage.Set<List<T_Sys_Dic>>(key, new CacheValue<List<T_Sys_Dic>>(province, true));

            return province;
        }

        /// <summary>
        /// 获取市
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<T_Sys_Dic> CityList(int parentId)
        {
            //var dic = _tEntityResponsity.GetById(parentId);
            //int code = Convert.ToInt32(dic.Code);
            List<T_Sys_Dic> city = _tEntityResponsity.Table.Where(w => w.ParentId == parentId).ToList();
            return city;
        }

        /// <summary>
        /// 获取行业
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> TradeList()
        {
            List<T_Sys_Dic> trade = _tEntityResponsity.Table.Where(w => w.DicType == "Trade").ToList();
            return trade;
        }

        /// <summary>
        /// 获取职位
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> CertificateList(int parentId)
        {
            var dic = _tEntityResponsity.GetById(parentId);
            int code = Convert.ToInt32(dic.Code);
            List<T_Sys_Dic> certificate = _tEntityResponsity.Table.Where(w => w.ParentId == code).ToList();
            return certificate;
        }

        /// <summary>
        /// 查询期望薪资
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetSalaryList()
        {
            List<T_Sys_Dic> trade = _tEntityResponsity.Table.Where(w => w.ParentId == 0 && w.DicType == "Salary").ToList();
            return trade;
        }

        /// <summary>
        /// 获取学历字典
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetDegreeList()
        {
            return _tEntityResponsity.Table.Where(x => x.DicType == "Degree").ToList();
        }
        /// <summary>
        /// 根据学历名称获取Code
        /// </summary>
        /// <param name="degreeName"></param>
        /// <returns></returns>
        public string GetDegreeCode(string degreeName)
        {
            var degreeCode = _tEntityResponsity.Table.Where(w => w.ChineseName == degreeName && w.DicType == "Degree").FirstOrDefault();
            if (degreeCode == null)
                return null;
            return degreeCode.Code;
        }

        /// <summary>
        /// 获取语言字典
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetLanguageList()
        {
            return _tEntityResponsity.Table.Where(x => x.DicType == "Language").ToList();
        }

        /// <summary>
        /// 根据语言名称获取Code
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public int GetLanguageCode(string languageName)
        {
            var language = _tEntityResponsity.Table.Where(w => w.ChineseName == languageName && w.DicType == "Language").FirstOrDefault();
            return language != null ? language.Id : 0;
        }

        /// <summary>
        /// 获取工作经验
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetWorkExperienceList()
        {
            return _tEntityResponsity.Table.Where(x => x.DicType == "WorkExperience").OrderBy(x => x.SortValue).ToList();
        }

        /// <summary>
        /// 获取语言水平
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetLanguageLevelList()
        {
            return _tEntityResponsity.Table.Where(x => x.DicType == "LanguageLevel").OrderBy(x => x.SortValue).ToList();
        }

        /// <summary>
        /// 根据语言能力名称获取Code
        /// </summary>
        /// <param name="languageLeveName"></param>
        /// <returns></returns>
        public string GetLanguageLeveCode(string languageLeveName)
        {
            var languageLeve = _tEntityResponsity.Table.Where(w => w.ChineseName == languageLeveName && w.DicType == "LanguageLevel").FirstOrDefault();
            return languageLeve != null ? languageLeve.Code : "0";
        }

        public List<T_Sys_Dic> GetCompanyPropertyList()
        {

            string key = cachePre + "companyProperty";

            //根据键值查找缓存中数据，如果没有再进行数据库查询
            if (_cacheStorage.Exists(key))
            {
                return _cacheStorage.Get<List<T_Sys_Dic>>(key).Value;
            }

            List<T_Sys_Dic> compertylist = _tEntityResponsity.Table.Where(w => w.ParentId == 0 && w.DicType == "CompanyProperty").ToList();

            _cacheStorage.Set<List<T_Sys_Dic>>(key, new CacheValue<List<T_Sys_Dic>>(compertylist, true));
            return compertylist;
        }
        /// <summary>
        /// 获取省市
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetProvinceAndCity()
        {
            string key = cachePre + "provinceCity";

            //根据键值查找缓存中数据，如果没有再进行数据库查询
            if (_cacheStorage.Exists(key))
            {
                return _cacheStorage.Get<List<T_Sys_Dic>>(key).Value;
            }

            List<T_Sys_Dic> provinceCitylist = _tEntityResponsity.Table.Where(w => w.DicType == "PLACE").ToList();

            _cacheStorage.Set<List<T_Sys_Dic>>(key, new CacheValue<List<T_Sys_Dic>>(provinceCitylist, true));
            return provinceCitylist;
        }

        /// <summary>
        /// 获取职位（一级）
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetJob()
        {
            var jobList = _tEntityResponsity.Table.Where(w => w.DicType == "Job" && w.ParentId == 0).ToList();
            return jobList;
        }

        /// <summary>
        /// 获取职位（二级）
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<T_Sys_Dic> GetJobList(int parentId)
        {
            var job = _tEntityResponsity.Table.Where(w => w.ParentId == parentId && w.DicType == "Job").ToList();
            return job;
        }

        /// <summary>
        /// 获取职位Code
        /// </summary>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        public string GetJobCode(string chineseName)
        {
            string result = string.Empty;
            string[] name = chineseName.Split(',');
            var Id = _tEntityResponsity.Table.Where(w => name.Contains(w.ChineseName) && w.ParentId != 0)
                .Where(w => w.DicType == "Job")
                .ToList();
            if (Id != null && Id.Count > 0)
            {
                foreach (var sys in Id)
                {
                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        result += "," + sys.Code.ToString();
                    }
                    else
                    {
                        result += sys.Code.ToString();
                    }
                }
            }
            return "," + result + ",";
        }
        /// <summary>
        /// 获取所有职业
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetOccupationList()
        {
            string key = cachePre + "occupation";

            //根据键值查找缓存中数据，如果没有再进行数据库查询
            if (_cacheStorage.Exists(key))
            {
                return _cacheStorage.Get<List<T_Sys_Dic>>(key).Value;
            }

            List<T_Sys_Dic> occuplist = _tEntityResponsity.Table.Where(w => w.DicType == "Job").ToList();

            _cacheStorage.Set<List<T_Sys_Dic>>(key, new CacheValue<List<T_Sys_Dic>>(occuplist, true));
            return occuplist;
        }

        /// <summary>
        /// 获取角色字典
        /// </summary>
        /// <returns></returns>
        public List<T_Sys_Dic> GetRoleList()
        {
            return _tEntityResponsity.Table.Where(w => w.DicType == "Role").ToList();
        }

        /// <summary>
        /// 获取流程字典
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_Sys_Dic> GetFlowList()
        {
            return _tEntityResponsity.Table.Where(x => x.DicType == "flow").ToList().OrderBy(x => x.SortValue);
        }
        /// <summary>
        /// 获取字典内容
        /// </summary>
        /// <param name="typename"></param>
        ///    /// <param name="parentid"></param>
        /// <param name="iscach"></param>
        /// <returns></returns>
        public List<T_Sys_Dic> getDicList(string typename, int parentid, string iscach)
        {
            string key = cachePre + typename + parentid;


            //根据键值查找缓存中数据，如果没有再进行数据库查询
            if (_cacheStorage.Exists(key))
            {
                if (iscach == "0")
                {
                    _cacheStorage.Delete(key);
                }
                else
                {
                    return _cacheStorage.Get<List<T_Sys_Dic>>(key).Value;
                }
            }
            List<T_Sys_Dic> occuplist = _tEntityResponsity.Table.Where(w => w.DicType == typename)
                                        .WhereIf(t => t.ParentId == parentid, parentid >= 0)
                                        .OrderBy(t => t.SortValue)
                                        .ToList();

            _cacheStorage.Set<List<T_Sys_Dic>>(key, new CacheValue<List<T_Sys_Dic>>(occuplist, true));
            return occuplist;
        }

        /// <summary>
        /// 查询实习经历字典
        /// </summary>
        /// <param name="type">实习周期或实习天数</param>
        /// <returns></returns>
        public List<T_Sys_Dic> GetInternship(string type)
        {
            var list = _tEntityResponsity.Table.Where(w => w.DicType == type).ToList();
            return list;
        }

        /// <summary>
        /// 管理端，查询字典
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        public IPagedList<T_Sys_Dic> GridDicList(int pageIndex, int pageSize, string chineseName, string dicType)
        {
            //string[] type = { "PLACE", "Trade", "Job" };
            var list = _tEntityResponsity.Table
                .Where(w => w.IsDelete == false)
                //.Where(w => type.Contains(w.DicType))
                .WhereIf(w => w.ChineseName.Contains(chineseName), !string.IsNullOrWhiteSpace(chineseName))
                .WhereIf(w => w.DicType == dicType, !string.IsNullOrWhiteSpace(dicType))
                .ToList();
            var pageList = new PagedList<T_Sys_Dic>(
                list
                , pageIndex
                , pageSize
                );
            //var jqlist = new JqGridResult<T_Sys_Dic>();
            //jqlist.records = pageList.TotalCount;
            //jqlist.rows = list;
            //jqlist.page = pageList.PageIndex;
            //jqlist.total = pageList.TotalPages;

            return pageList;
        }

        /// <summary>
        /// 管理端，添加或修改字典
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool CreateOrUpdateSysDic(T_Sys_Dic model)
        {
            if (model.Id != 0)
            {
                var dic = _tEntityResponsity.GetById(model.Id);
                dic.Code = model.Code;
                dic.ChineseName = model.ChineseName;
                dic.EnglishName = !string.IsNullOrWhiteSpace(model.EnglishName) ? model.EnglishName : "";
                _tEntityResponsity.Update(dic);
            }
            else
            {
                model.EnglishName = !string.IsNullOrWhiteSpace(model.EnglishName) ? model.EnglishName : "";
                model.CreateTime = DateTime.Now;
                model.UpdateTime = DateTime.Now;
                model.IsDelete = false;
                model.DicDetail = "";
                _tEntityResponsity.Insert(model);
            }
            return true;
        }

        /// <summary>
        /// 管理端，删除字典
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string DeleteSysDic(int Id)
        {
            try
            {
                var dic = _tEntityResponsity.GetById(Id);
                dic.IsDelete = true;
                dic.UpdateTime = DateTime.Now;
                _tEntityResponsity.Update(dic);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "成功";
        }

        /// <summary>
        /// 管理端，查询设置流程向
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        public IPagedList<T_Sys_Dic> GridDicFlowList(int pageIndex, int pageSize, string chineseName)
        {
            var list = _tEntityResponsity.Table
                .Where(w => w.IsDelete == false)
                .Where(w => w.DicType == "flow")
                .WhereIf(w => w.ChineseName.Contains(chineseName), !string.IsNullOrWhiteSpace(chineseName))
                .ToList();
            var pageList = new PagedList<T_Sys_Dic>(
                list
                , pageIndex
                , pageSize
                );
            //var jqlist = new JqGridResult<T_Sys_Dic>();
            //jqlist.records = pageList.TotalCount;
            //jqlist.rows = list;
            //jqlist.page = pageList.PageIndex;
            //jqlist.total = pageList.TotalPages;

            return pageList;
        }

        /// <summary>
        /// 获取广告位字典
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_Sys_Dic> GetAdvPosition()
        {
            return _dbContext.Set<T_Sys_Dic>().Where(x => x.DicType == "AdvPosition").ToList();
        }

        public IEnumerable<T_Sys_Dic> Where(Expression<Func<T_Sys_Dic, bool>> expression)
        {
            return _tEntityResponsity.Table.Where(x => x.IsDelete == false).Where(expression);
        }


        public T_Sys_Dic GetChineseNameByCodeAndDicType(string code, string dicType)
        {
            T_Sys_Dic dic = new T_Sys_Dic();
            List<T_Sys_Dic> list = _tEntityResponsity.Table.Where(x => x.Code == code && x.DicType == dicType).ToList();
            if (list != null && list.Count > 0)
            {
                dic = list[0];
            }
            return dic;
        }

        public List<KeyValuePair<string, string>> GetDicTypeList()
        {
            return _tEntityResponsity.Table
                 .GroupBy(x => new { x.DicType, x.DicTypeName })
                 .Select(x => x.Key)
                 .ToList()
                 .Select(x => new KeyValuePair<string, string>(x.DicType, x.DicTypeName)).ToList();
        }
    }
}