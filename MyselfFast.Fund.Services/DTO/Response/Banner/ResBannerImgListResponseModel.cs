using myselfFast.Fund.Core.Domain.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Banner
{
    [Serializable]
    public class ResBannerImgListResponseModel
    {
        public List<T_Helo_Img> list { get; set; }
        public int total { get; set; }
        public int pages { get; set; }
    }
}
