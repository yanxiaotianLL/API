using myselfFast.Fund.Core;
using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core;
using myselfFast.ZFBZ.Core.Domain.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Sys
{
    public interface ISysDicService : IBaseService<T_Sys_Dic>
    {
        /// <summary>
        /// 根据Id查询中文名称
        /// </summary>
        /// <param name="Id">主键Id</param>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        string ChineseName(int Id);
        string ChineseName(string Code);

        /// <summary>
        /// 根据中文名称获取Code
        /// </summary>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        string GetCode(string chineseName);

        List<KeyValuePair<string, string>> GetDicTypeList();

        /// <summary>
        /// 获取省
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> ProvinceList();

        /// <summary>
        /// 获取市
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        List<T_Sys_Dic> CityList(int parentId);

        /// <summary>
        /// 获取行业
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> TradeList();

        /// <summary>
        /// 获取职位
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> CertificateList(int parentId);

        /// <summary>
        /// 查询期望薪资
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetSalaryList();

        /// <summary>
        /// 获取学历字典
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetDegreeList();

        /// <summary>
        /// 根据学历名称获取Code
        /// </summary>
        /// <param name="degreeName"></param>
        /// <returns></returns>
        string GetDegreeCode(string degreeName);

        /// <summary>
        /// 获取语言字典
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetLanguageList();

        /// <summary>
        /// 根据语言名称获取Code
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        int GetLanguageCode(string languageName);

        /// <summary>
        /// 获取工作经验
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetWorkExperienceList();

        /// <summary>
        /// 获取语言水平
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetLanguageLevelList();

        /// <summary>
        /// 根据语言能力名称获取Code
        /// </summary>
        /// <param name="languageLeveName"></param>
        /// <returns></returns>
        string GetLanguageLeveCode(string languageLeveName);

        /// <summary>
        /// 公司性质
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetCompanyPropertyList();
        /// <summary>
        /// 获取省市
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetProvinceAndCity();

        /// <summary>
        /// 获取职位（一级）
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetJob();

        /// <summary>
        /// 获取职位（二级）
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        List<T_Sys_Dic> GetJobList(int parentId);

        /// <summary>
        /// 获取职位Code
        /// </summary>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        string GetJobCode(string chineseName);
        /// <summary>
        /// 获取所有职业
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetOccupationList();

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        List<T_Sys_Dic> GetRoleList();

        /// <summary>
        /// 获取流程字典
        /// </summary>
        /// <returns></returns>
        IEnumerable<T_Sys_Dic> GetFlowList();
        /// <summary>
        /// 获取字典内容
        /// </summary>
        /// <param name="typename"></param>
        /// <param name="parentid">0大类,非0为da</param>
        /// <param name="iscach">是否调用缓存</param>
        /// <returns></returns>
        List<T_Sys_Dic> getDicList(string typename, int parentid, string iscach);

        /// <summary>
        /// 查询实习经历字典
        /// </summary>
        /// <param name="type">实习周期或实习天数</param>
        /// <returns></returns>
        List<T_Sys_Dic> GetInternship(string type);

        /// <summary>
        /// 管理端，查询字典
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        IPagedList<T_Sys_Dic> GridDicList(int pageIndex, int pageSize, string chineseName, string dicType);
        /// <summary>
        /// 根据codeid和dictype获取中文名称
        /// </summary>
        /// <param name="codeId"></param>
        /// <param name="dicType"></param>
        /// <returns></returns>
        T_Sys_Dic GetChineseNameByCodeAndDicType(string codeId,string dicType);


        /// <summary>
        /// 管理端，添加或修改字典
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool CreateOrUpdateSysDic(T_Sys_Dic model);

        /// <summary>
        /// 管理端，删除字典
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        string DeleteSysDic(int Id);

        /// <summary>
        /// 管理端，查询设置流程向
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="chineseName"></param>
        /// <returns></returns>
        IPagedList<T_Sys_Dic> GridDicFlowList(int pageIndex, int pageSize, string chineseName);

        /// <summary>
        /// 获取广告位字典
        /// </summary>
        /// <returns></returns>
        IEnumerable<T_Sys_Dic> GetAdvPosition();

        IEnumerable<T_Sys_Dic> Where(Expression<Func<T_Sys_Dic, bool>> expression);
    }
}
