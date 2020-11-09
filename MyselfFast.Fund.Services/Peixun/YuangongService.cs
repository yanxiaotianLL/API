 using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Peixun;
using myselfFast.Fund.Services.DTO.Request.Peixun;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using myselfFast.Fund.Services.DTO.Response.Peixun;

namespace myselfFast.Fund.Services.Peixun
{
    public class YuangongService : BaseService<T_Trn_Stu>, IYuangongService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private IImportFileImpService _ImportFile;
        private readonly ILogger _logger = null;
        private IRepository<T_Trn_Label> _tTrnLabelEntity;
        public YuangongService(IRepository<T_Trn_Stu> tEntityResponsity,
            IRepository<T_Trn_Label> tTrnLabelEntity,
            IImportFileImpService ImportFileImpService,
            IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._tTrnLabelEntity = tTrnLabelEntity;
            this._ImportFile = ImportFileImpService;
        }
        //获取员工列表
        public JqGridResult<ResYuangongResponseModel> GetYuangongList(SelectYuangongRequestModel model, T_Admin_Account account, int rows, int page)
        {
            var begintime = Utils.ToDateTime(model.CreateTimeStart); 
            var endtime = Utils.ToDateTime(model.CreateTimeEnd);

            if (!string.IsNullOrEmpty(model.CreateTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }
            //if (!string.IsNullOrEmpty(model.PersonName) && model.PersonName != "undefined")
            //{
            //    model.PersonName = Encryption.Encrypt(model.PersonName);
            //}
            //if (!string.IsNullOrEmpty(model.PersonId) && model.PersonId != "undefined")
            //{
            //    model.PersonId = Encryption.Encrypt(model.PersonId);
            //}
            string sqlText = string.Format("EXEC P_PeixunYuangong_Info @id={0}", 0);
            List<ResYuangongResponseModel> pagedListOld = new List<ResYuangongResponseModel>(
                _dbContext.SqlQuery<ResYuangongResponseModel>(sqlText, true)
                //查询条件
                .WhereIf(t => t.PersonName.Contains(model.PersonName), !string.IsNullOrEmpty(model.PersonName) && model.PersonName != "undefined") //姓名
                .WhereIf(t => t.PersonId == model.PersonId, !string.IsNullOrEmpty(model.PersonId) && model.PersonId != "undefined")
                .WhereIf(t => t.Hno == model.Hno, model.Hno > 0)
                .WhereIf(t => t.Yewubu == model.Yewubu, !string.IsNullOrEmpty(model.Yewubu) && model.Yewubu != "undefined")
                //.WhereIf(t => t.LabelIds.Contains(model.LabelId), !string.IsNullOrEmpty(model.LabelId) && model.LabelId != "-1")
                .WhereIf(t => t.IsActive == model.IsActive, model.IsActive > -1)
                .WhereIf(t => t.busiCustName.Contains(model.busiCustName), !string.IsNullOrEmpty(model.busiCustName)) //公司
                .WhereIf(t => t.CreateTime >= begintime, !string.IsNullOrEmpty(model.CreateTimeStart))
                .WhereIf(t => t.CreateTime <= endtime, !string.IsNullOrEmpty(model.CreateTimeEnd))
                );

            List<ResYuangongResponseModel> pagedList = new List<ResYuangongResponseModel>();
            if (!string.IsNullOrEmpty(model.LabelId) && model.LabelId != "-1," && model.LabelId != ",")
            {
                string[] LabelIds = model.LabelId.Split(",");
                List<ResYuangongResponseModel> pagedListNew = new List<ResYuangongResponseModel>();
                List<int> CozId = new List<int>();
                foreach (string idss in LabelIds)
                {
                    if (idss != "")
                    {
                        pagedListNew = pagedListOld.Where(t => t.LabelIds.Contains("," + idss + ",")).ToList();
                    }
                    //如果该便签 记录存在
                    if (!string.IsNullOrEmpty(idss) && idss != "" && pagedListNew != null && pagedListNew.Count > 0)
                    {
                        foreach (ResYuangongResponseModel coz in pagedListNew)
                        {
                            CozId.Add(coz.Id);
                            //判断列表是有没有，没有则追加
                            List<ResYuangongResponseModel> pagedListTemp = pagedList.Where(t => t.Id == coz.Id).ToList();
                            if (pagedListTemp == null || pagedListTemp.Count <= 0)
                            {
                                pagedList.Add(coz);
                            }
                        }
                    } 
                }
            }
            else
            {
                pagedList.AddRange(pagedListOld);
            }

            List<T_Trn_Label> LabelIdsName = GetLabelIdsName();

            foreach (ResYuangongResponseModel v in pagedList)
            {
                v.LabelIdsName = "";
                string[] ids = v.LabelIds.Split(",");
                List<T_Trn_Label> sName = LabelIdsName.Where(t => ids.Contains(Utils.ToString(t.Id))).ToList();

                foreach (T_Trn_Label l in sName)
                {
                    v.LabelIdsName += l.Name + "</br>";
                }
            }
            IPagedList<ResYuangongResponseModel> vPagedList = new PagedList<ResYuangongResponseModel>(pagedList, page, rows);
            return JqGridResult<ResYuangongResponseModel>.Build(vPagedList);
        }
        public List<T_Trn_Label> GetLabelIdsName()
        {
            return _tTrnLabelEntity.Table.Where(t => t.Id > 0 && t.IsDelete == 0).ToList();
        }
        //培训员工导入
        public string YuangongDataIn(string FileNameOld, string path, T_Admin_Account account, string LableId)
        {
            //文件路径
            string result = string.Empty;
            result = _ImportFile.InsertAndUploadSystemImportFile(FileNameOld, path, account,LableId);
            return result;
        }
        //获取便签列表名称
        public List<T_Trn_Label> GetLabelIdsText()
        {
            return   _tTrnLabelEntity.Table.Where(t => t.Id > 0 && t.IsDelete == 0).ToList();  
        }
        //获取便签列表
        public List<ResPeixunLableResponseModel> getTrnLabelList()
        {
            List<ResPeixunLableResponseModel> result = ((from order in _tTrnLabelEntity.Table
                                                         where order.IsDelete == 0
                                                         select new ResPeixunLableResponseModel
                                                         {
                                                             Id = order.Id,
                                                             Name = order.Name,
                                                             CreateTime = order.CreateTime,
                                                             IsDelete = order.IsDelete,
                                                             AliId = order.AliId,
                                                             isclosable = ""
                                                         })).ToList();

            //标签是否可以删除（该分类下没有归属任一课程或学员。）
            string sqlText = string.Format("EXEC P_PeixunLabel_Info");
            List<String> LabelIdsList = new List<String>(_dbContext.SqlQuery<String>(sqlText, true));
            List<string> lblisclosable = new List<string>();
            foreach (string Lb in LabelIdsList)
            {
                string[] lbl = Lb.Split(",");
                foreach (string lb in lbl)
                {
                    if (lblisclosable.Exists(x => x == lb) == false)
                    {
                        lblisclosable.Add(lb);
                    }
                }
            }

            foreach (ResPeixunLableResponseModel u in result)
            {
                u.isclosable = "closable"; //默认可删除
                if (lblisclosable.Exists(x => Utils.ToInt(x) == u.Id) == true)
                {
                    u.isclosable = ""; //不可删除
                }
            }

            return result;
        }
    }
}
