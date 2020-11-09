using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Peixun
{

    public class txtResponse
    {
        public string Success { get; set; }

        public GetPlayInfoResponseModel Data { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }


    public class GetPlayInfoResponseModel
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// 视频基本信息
        /// </summary>
        public VideoBase VideoBase { get; set; }
        /// <summary>
        /// 视频流信息列表
        /// </summary>
        public List<PlayInfo> PlayInfoList { get; set; }
        /// <summary>
        /// 视频简介
        /// </summary>
        public string VideoDes { get; set; }
        /// <summary>
        /// 最后一次看到视频时间点(单位：s)
        /// </summary>
        public int LastPoint { get; set; }
    }

    public class VideoBase
    {
        /// <summary>
        /// 视频ID
        /// </summary>
        public string VideoId { get; set; }
        /// <summary>
        /// 视频标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 视频时长（秒）
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// 视频封面
        /// </summary>
        public string CoverURL { get; set; }
        /// <summary>
        /// 视频状态
        /// </summary>
        public string Status { get; set; }

        private string _creationTime;
        /// <summary>
        /// 视频创建时间。使用UTC时间
        /// </summary>
        public string CreationTime
        {
            get
            {
                return DateTimeOffset.Parse(_creationTime).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                _creationTime = value;
            }
        }
        /// <summary>
        /// 媒体文件类型（video：视频，audio：纯音频）
        /// </summary>
        public string MediaType { get; set; }
    }

    public class PlayInfo
    {
        /// <summary>
        /// 视频流长度，单位秒
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// 视频流的播放地址
        /// </summary>
        public string PlayURL { get; set; }
        /// <summary>
        /// 视频流格式
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// 视频流大小，单位Byte
        /// </summary>
        public long? Size { get; set; }
        /// <summary>
        /// 视频流宽度，单位px
        /// </summary>
        public long? Width { get; set; }
        /// <summary>
        /// 视频流高度，单位px
        /// </summary>
        public long? Height { get; set; }

    }
}
