using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.Banner;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Banner;

namespace myselfFast.Fund.Services.Banner
{
    public interface IBannerHoleImgDataService : IBaseService<T_Helo_Img>
    {
        /// <summary>
        /// 获取Banner img 列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        JqGridResult<T_Helo_Img> GetBannerImgDataList(SelectBannerImgListRequestModel model, int rows, int page);
        string AddBannerImgData(T_Helo_Img imgData, T_Admin_Account account);
        string editBannerImgData(T_Helo_Img imgData, T_Admin_Account account);
        string delBannerImgData(string id,int ImgState, T_Admin_Account account);
        T_Helo_Img GetBannerImgData(string id);
    }
}
