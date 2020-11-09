using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Banner;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Banner;
using myselfFast.Fund.Services.DTO.Response.Banner;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;


namespace myselfFast.Fund.Services.Banner
{
    public class BannerHoleImgDataService : BaseService<T_Helo_Img>, IBannerHoleImgDataService
    {
        public BannerHoleImgDataService(IRepository<T_Helo_Img>  tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
        }
        /// <summary>
        /// 获取Banner img 列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public JqGridResult<T_Helo_Img> GetBannerImgDataList(SelectBannerImgListRequestModel model, int rows, int page)
        {
            IPagedList<T_Helo_Img> pagedList = new PagedList<T_Helo_Img>(_tEntityResponsity.Table
                //查询条件
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t =>t.ImgTitle.Contains(model.ImgTitle), !string.IsNullOrEmpty(model.ImgTitle))
                .WhereIf(t => t.ImgState == model.ImgState, model.ImgState > -1)
                .WhereIf(t => t.ImgPlace == model.ImgPlace, model.ImgPlace > 0).OrderByDescending(t => t.Id), page, rows);

            return JqGridResult<T_Helo_Img>.Build(pagedList);
        }
        /// <summary>
        /// 添加 Banner img 
        /// </summary>
        /// <param name="imgData"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string AddBannerImgData(T_Helo_Img imgData, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                if (imgData.ImgPlace != 1)
                {
                    imgData.ImgBackColor = "";
                }
                T_Helo_Img temImgIndex = this._tEntityResponsity.Table.Where(p => p.ImgIndex == imgData.ImgIndex && p.ImgState == 0 && p.ImgPlace == imgData.ImgPlace).FirstOrDefault();
                if (temImgIndex != null && temImgIndex.Id > 0)
                {
                    return "此位置当前顺序已经存在轮播图！";
                }
                imgData.CrtUser = account.UserName;
                imgData.CrtTime = DateTime.Now;
                imgData.UpdtUser = account.UserName;
                imgData.UpdtTime = DateTime.Now;
                this.AddEntity(imgData);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="imgData"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string editBannerImgData(T_Helo_Img imgData, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                if (imgData.ImgPlace != 1)
                {
                    imgData.ImgBackColor = "";
                }
                T_Helo_Img temImgIndex = this._tEntityResponsity.Table.Where(p => p.ImgIndex == imgData.ImgIndex && p.ImgState == 0 && p.ImgPlace == imgData.ImgPlace).FirstOrDefault();
                if (temImgIndex != null && temImgIndex.Id > 0 && imgData.ImgIndex!=temImgIndex.ImgIndex)
                {
                    return "此位置当前顺序已经存在轮播图！";
                }
                T_Helo_Img i = this.GetById(Utils.ToInt(imgData.Id));
                i.ImgTitle = imgData.ImgTitle;
                i.ImgState = 0;
                i.ImgPlace = imgData.ImgPlace;
                i.ImgBackColor = imgData.ImgBackColor;
                i.ToUrl = imgData.ToUrl;
                i.ImgIndex = imgData.ImgIndex;
                i.UpdtUser = account.UserName;
                i.UpdtTime = DateTime.Now;
                this.UpdateEntity(i);
                return string.Empty;
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        /// <summary>
        /// 下线/上线
        /// </summary>
        /// <param name="id"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public string delBannerImgData(string id,int ImgState, T_Admin_Account account)
        {
            try
            {
                //下线/上线
                T_Helo_Img i = this.GetById(Utils.ToInt(id));
                i.ImgState = ImgState;
                i.UpdtUser = account.UserName;
                i.UpdtTime = DateTime.Now;
                if (ImgState == 1)
                {
                    List<T_Helo_Img> temImgIndex = this._tEntityResponsity.Table.Where(p => p.ImgState == 0 && p.ImgPlace == i.ImgPlace).ToList<T_Helo_Img>(); ;
                    
                    if (temImgIndex != null && temImgIndex.Count <= 1)
                    {
                        return "下线失败，该位置轮播图至少要保留一个上线内容！";
                    }
                }
                this.UpdateEntity(i);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public T_Helo_Img GetBannerImgData(string id)
        {
            T_Helo_Img d = this.GetById(Utils.ToInt(id));
            return d;
        }
    }
}
