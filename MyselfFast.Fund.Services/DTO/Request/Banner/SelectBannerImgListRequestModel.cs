using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Banner
{
    [Serializable]
    public partial  class SelectBannerImgListRequestModel
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        public string ImgTitle { get; set; }

        public int ImgState { get; set; }

        public int ImgPlace { get; set; }
    }
}
