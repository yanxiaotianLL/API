//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Banner
{
    [Serializable]
    public partial class T_Helo_Img : BaseEntity
    {
        public string ImgUrl { get; set; }
        public string ImgTitle { get; set; }
        public int ImgState { get; set; }
        public string ToUrl { get; set; }
        public int ImgIndex { get; set; }
        public int ImgPlace { get; set; }
        public string ImgBackColor { get; set; }
        public System.DateTime CrtTime { get; set; }
        public string CrtUser { get; set; }
        public System.DateTime UpdtTime { get; set; }
        public string UpdtUser { get; set; }
    }
}
