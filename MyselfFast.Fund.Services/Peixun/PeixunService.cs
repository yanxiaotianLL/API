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
using myselfFast.Fund.Services.DTO.Response.Peixun;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using myselfFast.Fund.Core.Configuration;
using WebApiDebugTool.Helper;

namespace myselfFast.Fund.Services.Peixun
{
    public class PeixunService : BaseService<T_Trn_CozInfo>, IPeixunService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Trn_Label> _tTrnLabelEntity;
        public PeixunService(IRepository<T_Trn_CozInfo> tEntityResponsity,
            IRepository<T_Trn_Label> tTrnLabelEntity,
            IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._tTrnLabelEntity = tTrnLabelEntity;
        }
        //获取课程列表
        public JqGridResult<ResPeixunCozInfoResponseModel> GetPeixunList(SelectPeixunRequestModel model, T_Admin_Account account, int rows, int page)
        {
            var begintime = Utils.ToDateTime(model.BeginTimeStart); 
            var endtime = Utils.ToDateTime(model.BeginTimeEnd);

            if (!string.IsNullOrEmpty(model.BeginTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }
            List<T_Trn_CozInfo> pagedListOld = new List<T_Trn_CozInfo>(_tEntityResponsity.Table
                //查询条件
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t => t.Name.Contains(model.Name), !string.IsNullOrEmpty(model.Name) && model.Name != "undefined") //课程名称
                .WhereIf(t => t.IsOpen == model.IsOpen, model.IsOpen > -1)
                .WhereIf(t => t.BeginTime >= begintime, !string.IsNullOrEmpty(model.BeginTimeStart) && model.BeginTimeStart != "undefined")
                .WhereIf(t => t.BeginTime <= endtime, !string.IsNullOrEmpty(model.BeginTimeEnd) && model.BeginTimeEnd != "undefined")
                .OrderByDescending(t => t.IsOpen).ThenByDescending(t => t.BeginTime));
            List<T_Trn_CozInfo> pagedList = new List<T_Trn_CozInfo>();
            if (!string.IsNullOrEmpty(model.LabelId) && model.LabelId != "-1," && model.LabelId != ",")
            {
                //循环查找标签
                string[] LabelIds = model.LabelId.Split(",");
                List<int> CozId=new List<int>();
                //多选条件
                foreach (string idss in LabelIds)
                {
                    List<T_Trn_CozInfo> pagedListNew = new List<T_Trn_CozInfo>();
                    if (idss != "")
                    {
                        pagedListNew = pagedListOld.Where(t => t.LabelIds.Contains("," + idss + ",")).ToList();
                    }
                    //如果该便签 记录存在
                    if (!string.IsNullOrEmpty(idss) && idss != "" && pagedListNew != null && pagedListNew.Count>0)
                    {
                        foreach (T_Trn_CozInfo coz in pagedListNew)
                        {
                            CozId.Add(coz.Id);
                            //判断列表是有没有，没有则追加
                            List<T_Trn_CozInfo> pagedListTemp = pagedList.Where(t => t.Id==coz.Id).ToList();
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
            
            
            List<ResPeixunCozInfoResponseModel> vList = new List<ResPeixunCozInfoResponseModel>();
           
            foreach (T_Trn_CozInfo p in pagedList)
            {
                ResPeixunCozInfoResponseModel vPage = new ResPeixunCozInfoResponseModel
                {
                    Id = p.Id
                    ,
                    Name = p.Name
                    ,
                    IsOpen = p.IsOpen
                    ,
                    BeginTime = p.BeginTime
                    ,
                    EndTime = p.EndTime
                    ,
                    Credit = p.Credit
                    ,
                    OpenDegree = p.OpenDegree
                    ,
                    VideoId = p.VideoId
                    ,
                    ThumbnailSrc = p.ThumbnailSrc
                    ,
                    TrnFileSrc = p.TrnFileSrc
                    ,
                    IsText = p.IsText
                    ,
                    SumMin = p.SumMin
                    ,
                    TrnContent = p.TrnContent
                    ,
                    LabelIds = p.LabelIds
                    ,
                    IsDelete = p.IsDelete
                    ,
                    CreateUserId = p.CreateUserId
                    ,
                    CreatTime = p.CreatTime
                    ,
                    EditUserId = p.EditUserId
                    ,
                    EditTime = p.EditTime
                };
                vList.Add(vPage);
            }
            //IPagedList<ResPeixunCozInfoResponseModel> vPagedList = pagedList.CastTo<IPagedList<ResPeixunCozInfoResponseModel>>();

            List<T_Trn_Label> LabelIdsName = GetLabelIdsName();

            foreach (ResPeixunCozInfoResponseModel v in vList)
            {
                v.LabelIdsName = "";
                string[]  ids = v.LabelIds.Split(",");
                List<T_Trn_Label> sName = LabelIdsName.Where(t => ids.Contains(Utils.ToString(t.Id))).ToList();

                foreach (T_Trn_Label l in sName)
                {
                    v.LabelIdsName += l.Name +"</br>";
                }
            }
            IPagedList<ResPeixunCozInfoResponseModel> vPagedList = new PagedList<ResPeixunCozInfoResponseModel>(vList, page, rows);
            return JqGridResult<ResPeixunCozInfoResponseModel>.Build(vPagedList);
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
        //获取便签列表名称
        public string  GetLabelById(int id)
        {
            string res="";
            T_Trn_Label lbl= _tTrnLabelEntity.Table.Where(t => t.Id ==id && t.IsDelete == 0).Last();
            if(lbl!=null && lbl.Id>0)
            {
                res=lbl.Name;
            }
            return res;
        }
        public List<T_Trn_Label> GetLabelIdsName()
        {
            return _tTrnLabelEntity.Table.Where(t => t.Id > 0 && t.IsDelete == 0).ToList();
        }
        //获取便签列表名称
        public List<string> GetLabelIdsText()
        {
            List<string> result = new List<string>();
            List<T_Trn_Label> temDt = _tTrnLabelEntity.Table.Where(t => t.Id > 0 && t.IsDelete == 0).ToList(); 
            foreach (T_Trn_Label tDt in temDt)
            {
                result.Add(tDt.Name);
            }
            return result;
        }
        //添加标签
        public string AddLabel(string name)
        {
            string result = string.Empty;
            T_Trn_Label temDt =new T_Trn_Label();
            List<T_Trn_Label> temp = _tTrnLabelEntity.Table.Where(t => t.Name == name && t.IsDelete == 0).ToList();
            if (temp != null && temp.Count > 0)
            {
                result = "添加失败，标签已存在！";
            }
            else
            {
                temDt.SetNullToDefalut();
                temDt.Name = name;
                temDt.CreateTime = DateTime.Now;
                temDt.IsDelete = 0;
                _tTrnLabelEntity.Insert(temDt);
                //添加阿里云分类接口
                #region 添加阿里云分类接口
                //try
                //{

                //    Stopwatch sw = new Stopwatch();
                     
                //    string paramter = string.Empty;
                //    setAddCategoryModel pp = new setAddCategoryModel();
                //    pp.Action = "AddCategory";
                //    pp.CateName = name;
                //    pp.ParentId = -1;

                //    string txtRequestBody = "{\"Action\":\"" + pp.Action + "\","
                //                    + "\"CateName\":\"" + pp.CateName + "\","
                //                    + "\"ParentId\":\"" + pp.ParentId 
                //                    + "\"}";


                //    paramter = HttpParmpterHelper.CreatePostParm(txtRequestBody);

                //    string txtUrl = FSGlobalConfiguration.Configuration.ExaminConfiguration.ApiSdkUrl;
                //    string txtController = "AliyunVideo";
                //    string txtAction = "AddCategory";
                //    string Url = string.Format("{0}{1}/{2}", txtUrl, txtController, txtAction);

                //    sw.Start();
                //    string txtRequestHeader = "User-Agent: AppWebApiTools bHost: localhost:1599 Content-Type: application/json";
                //    var re = HttpHelper.httpPost(Url, paramter, GetHeaders(txtRequestHeader));
                //    sw.Stop();
                //    txtResponseAdd data = JsonHelper.DeserializeJsonToObject<txtResponseAdd>(re);
                //    if (data.Code == "0")
                //    {
                //        AddCategoryResponseModel Response = data.Data;
                //        temDt.AliId = Utils.ToString(Response.Category.CateId); 
                //    }
 
                //}
                //catch (Exception ex)
                //{
                //    _logger.Info(this.GetType(), "添加阿里云分类异常" +ex.Message);
                //    temDt.AliId = "0";
                //}
                //finally
                //{
                //    temDt.AliId = "0";
                //}
                #endregion

                _tTrnLabelEntity.Update(temDt);
            }
            return result;
        }
        private Dictionary<string, string> GetHeaders(string strHeader)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(strHeader.Trim()))
            {
                string[] array = strHeader.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var item in array)
                {
                    string[] head = item.Split(':');
                    headers.Add(head[0], head[1]);
                }
            }

            return headers;
        }
        public int getLabelIdbyName(string name)
        {
            int result = 0;
            List<T_Trn_Label> tempList = _tTrnLabelEntity.Table.Where(t => t.Name == name && t.IsDelete == 0).ToList();
            T_Trn_Label temp=tempList.First();
            if (temp != null && temp.Id > 0)
            {
                return temp.Id;
            }
            return result;
        }
        //删除标签
        public string delLabel(int id)
        {
            string result = string.Empty;
            T_Trn_Label temDt = _tTrnLabelEntity.GetById(id);
            if (temDt != null && temDt.Id > 0)
            {
                temDt.IsDelete = 1;
                temDt.AliId = "";
                _tTrnLabelEntity.Update(temDt);
                //添加阿里云分类接口
                #region 删除阿里云分类接口
                //try
                //{

                //    Stopwatch sw = new Stopwatch();

                //    string paramter = string.Empty;
                //    setDeleteCategory pp = new setDeleteCategory();
                //    pp.Action = "DeleteCategory";
                //    pp.CateId =Utils.ToInt64(temDt.AliId);
                    

                //    string txtRequestBody = "{\"Action\":\"" + pp.Action + "\","
                //                    + "\"CateId\":\"" + pp.CateId
                //                    + "\"}";


                //    paramter = HttpParmpterHelper.CreatePostParm(txtRequestBody);

                //    string txtUrl = FSGlobalConfiguration.Configuration.ExaminConfiguration.ApiSdkUrl;

                //    string txtController = "AliyunVideo";
                //    string txtAction = "DeleteCategory";
                //    string Url = string.Format("{0}{1}/{2}", txtUrl, txtController, txtAction);

                //    sw.Start();
                //    string txtRequestHeader = "User-Agent: AppWebApiTools bHost: localhost:1599 Content-Type: application/json";
                //    var re = HttpHelper.httpPost(Url, paramter, GetHeaders(txtRequestHeader));
                //    sw.Stop();
                //    txtResponseDel data = JsonHelper.DeserializeJsonToObject<txtResponseDel>(re);
                //    if (data.Code == "0")
                //    {
                //        DeleteCategoryResponseModel Response = data.Data;
                        
                //    }

                //}
                //catch (Exception ex)
                //{
                //    _logger.Info(this.GetType(), "添加阿里云分类异常" + ex.Message);
                     
                //}
                //finally
                //{
                    
                //}
                #endregion
            }
            else
            {
                result = "数据异常！";
            }
            return result;
        }
        //开放
        public string IsOpen(int id)
        {
            string result = string.Empty;
            T_Trn_CozInfo temDt = _tEntityResponsity.GetById(id);
            if (temDt != null && temDt.Id > 0)
            {
                temDt.IsOpen = 1;
                _tEntityResponsity.Update(temDt);
            }
            else
            {
                result = "数据异常！";
            }
            return result;
        }
        //关闭
        public string IsClose(int id)
        {
            string result = string.Empty;
            T_Trn_CozInfo temDt = _tEntityResponsity.GetById(id);
            if (temDt != null && temDt.Id > 0)
            {
                temDt.IsOpen = 0;
                _tEntityResponsity.Update(temDt);
            }
            else
            {
                result = "数据异常！";
            }
            return result;
        }
        //添加保存
        public string addSave(T_Trn_CozInfo model, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_Trn_CozInfo trnCoz = new T_Trn_CozInfo();
                
               
                model.CreateUserId = account.Id;
                model.CreatTime = DateTime.Now;
                model.EditUserId = account.Id;
                model.EditTime = DateTime.Now;
                model.BeginTime = Utils.ToDateTime(model.BeginTime);
                model.EndTime =  model.BeginTime.AddYears(30);
                if (model.IsText == 1)
                {
                    model.VideoId = "";
                }
                else
                {
                    model.ThumbnailSrc = "";
                    model.TrnFileSrc = "";
                }
                if (model.OpenDegree == 0)
                {
                    model.LabelIds = "";
                }
                model.IsDelete = 0;
                model.IsOpen = 1;       //新增课程默认为开放状态
                trnCoz = model;
                trnCoz.SetNullToDefalut();
                this.AddEntity(trnCoz);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //获取修改数据
        public T_Trn_CozInfo GetPeixun(int id)
        {
            return _tEntityResponsity.GetById(id);

        }
        //保存修改内容
        public string editSave(T_Trn_CozInfo model, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_Trn_CozInfo trnCoz = _tEntityResponsity.GetById(model.Id);
                trnCoz.Name = model.Name;
                trnCoz.IsOpen = model.IsOpen;
                trnCoz.BeginTime = model.BeginTime;
                trnCoz.EndTime = model.BeginTime.AddYears(30);
                trnCoz.Credit = model.Credit;
                trnCoz.OpenDegree = model.OpenDegree;
                if (model.IsText == 1)
                {
                    trnCoz.ThumbnailSrc = model.ThumbnailSrc;
                    trnCoz.TrnFileSrc = model.TrnFileSrc;
                    trnCoz.VideoId = "";
                }
                else
                {
                    trnCoz.VideoId = model.VideoId;
                    trnCoz.ThumbnailSrc = "";
                    trnCoz.TrnFileSrc = "";
                }

                if (trnCoz.OpenDegree == 0)
                {
                    trnCoz.LabelIds = "";
                }
                else
                {
                    trnCoz.LabelIds = model.LabelIds;
                }

               
                
                trnCoz.IsText = model.IsText;
                trnCoz.SumMin = model.SumMin;
                trnCoz.TrnContent = model.TrnContent;
                
                trnCoz.IsDelete = 0;

                trnCoz.EditUserId = account.Id;
                trnCoz.EditTime = DateTime.Now;
                trnCoz.SetNullToDefalut();
                this.UpdateEntity(trnCoz);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //获取视频详情 
        public GetPlayInfoResponseModel GetPlayInfo(string VideoId)
        {
            GetPlayInfoResponseModel result = new GetPlayInfoResponseModel();
            #region 获取视频详情
            try
            {

                Stopwatch sw = new Stopwatch();

                setGetPlayInfo pp = new setGetPlayInfo();
                pp.Action = "GetPlayInfo";
                pp.VideoId = VideoId;
                string test = "{\"Action\":\"" + pp.Action + "\",\"txtAction\":\"" + pp.VideoId + "\"}";
                string txtRequestBody = "{\"Action\":\"" + pp.Action + "\","
                                + "\"VideoId\":\"" + pp.VideoId
                                + "\"}";
                string paramter = HttpParmpterHelper.CreateGetUrlAndParm(txtRequestBody);

                string txtUrl = FSGlobalConfiguration.Configuration.ExaminConfiguration.ApiSdkUrl;
                string txtController = "AliyunVideo";
                string txtAction = "GetPlayInfo";
                string Url = string.Format("{0}{1}/{2}", txtUrl, txtController, txtAction) + paramter;

                sw.Start();
                string txtRequestHeader = "User-Agent: AppWebApiTools bHost: localhost:1599 Content-Type: application/json";
                var re = HttpHelper.HttpGetString(Url, GetHeaders(txtRequestHeader));
                 
                sw.Stop();
                txtResponse data = JsonHelper.DeserializeJsonToObject<txtResponse>(re);
                if (data.Code == "0")
                {
                    result = data.Data;
                }
                
                 
            }
            catch (Exception ex)
            {
                _logger.Info(this.GetType(), "阿里云获取视频详情" + ex.Message);
            }
            finally
            {
                 
            }
            #endregion
            return result;
        }
    }
}
