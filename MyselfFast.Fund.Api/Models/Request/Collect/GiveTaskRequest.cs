using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api.Models.Request.Collect
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Api.Models.Request.Collect
	 *项目描述  ：
	 *类名称    ：GiveTaskRequest
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : GiveTaskRequest
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-02-02 15:37:11
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/
    /// <summary>
    /// 新系统集采任务下发请求实体
    /// </summary>
    public class GiveTaskRequest : IValidatableObject
    {
        /// <summary>
        /// 新系统批次标识
        /// </summary>
        [Required(ErrorMessage = "TaskBatchCode:(新系统批次标识不能为空)")]
        public string TaskBatchCode { get; set; }
        /// <summary>
        /// 新系统集采订单
        /// </summary>
        //[Required(ErrorMessage = "StartTime:(新系统采集任务订单ID不能为空)")]
        public string OrderID { get; set; }
        /// <summary>
        /// 集采产品 
        //0  公积金和社保
        //1  社保
        //2  公积金
        /// </summary>
        [Range(0, 2, ErrorMessage = "CollectProduct只能为（0:公积金和社保,1:社保,2:公积金）")]
        public int CollectProduct { get; set; }
        /// <summary>
        /// 工资采集精度，以元为单位 
        /// 0 标识精度元
        /// 1 标识精度角
        /// 2 标识精度分
        /// </summary>        
        [Range(0, 2, ErrorMessage = "WageAccuracy只能为（0:标识精度元,1:标识精度角,2:标识精度分）")]
        public int WageAccuracy { get; set; }
        /// <summary>
        /// 采集类型： A或者B
        /// </summary>
        [Required(ErrorMessage = "CollectlType:（采集类型： A或者B），不能为空")]
        public string CollectlType { get;set;}
        /// <summary>
        /// 采集开始日期:
        /// 格式:  yyyy-MM-dd hh:mm:ss
        /// </summary>
        [Required(ErrorMessage = "StartTime:(采集开始日期不能为空)")]
        public string StartTime { get; set; }
        /// <summary>
        /// 采集结束日期:
        /// 格式:  yyyy-MM-dd hh:mm:ss
        /// </summary>
        [Required(ErrorMessage = "EndTime:(采集结束日期不能为空)")]
        public string EndTime { get; set; }
        /// <summary>
        /// 采集地区
        /// </summary>
        [Required(ErrorMessage = "Address:(采集地区不能为空)")]
        public string Address { get; set; }
        /// <summary>
        /// 采集地区ID
        /// </summary>
        [Required(ErrorMessage = "AddressID:(采集地区ID不能为空)")]
        public string AddressID { get; set; }
        /// <summary>
        /// 采集任务描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 采集比例集合
        /// </summary>
         //[Required(ErrorMessage = "CollectionRate:(采集比例集合不能为空)")]
        public string CollectionRate { get; set; }
        /// <summary>
        /// 采集非实开比例集合
        /// </summary>
        //[Required(ErrorMessage = "CollectionRate:(采集比例集合不能为空)")]
        public string NotCollectionRate { get; set; }
        /// <summary>
        /// 采集任务类型 0：普通采集,1：补充采集
        /// </summary>
        [Range(0, 1, ErrorMessage = "采集任务类型 0：普通采集,1：补充采集")]
         public int TaskType { get; set; }
        /// <summary>
        /// 文件集合
        /// </summary>
         [Required(ErrorMessage = "CollectFiles:(文件集合不能为空)")]
        public List<CollectFile> CollectFiles { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CollectFiles == null || CollectFiles.Count <= 0)
            {
                yield return new ValidationResult("CollectFiles:(文件集合不能为空)");
            }

            DateTime startTime;
            DateTime endTime;
            bool sFlag = DateTime.TryParse(this.StartTime,out startTime);
            bool eFlag = DateTime.TryParse(this.EndTime,out endTime);

            if(!sFlag){
                yield return new ValidationResult("StartTime:(采集任务开始日期格式不正确，请参照 yyyy-MM-dd)");
            }
            if (!eFlag)
            {
                yield return new ValidationResult("EndTime:(采集任务开始日期格式不正确，请参照 yyyy-MM-dd)");
            }
            if (startTime <= DateTime.Now)
            {
                yield return new ValidationResult("StartTime:(开始日期不能小于当前日期)");
            }
            if (endTime <= DateTime.Now)
            {
                yield return new ValidationResult("EndTime:(结束日期不能小于当前日期)");
            }
            if(startTime >= endTime){
                yield return new ValidationResult("集采任务的结束日期不能小于开始日期");
            }
            if ((CollectProduct == 0 || CollectProduct == 2) && string.IsNullOrWhiteSpace(CollectionRate))
            {
                yield return new ValidationResult("采集比例集合(CollectionRate):不能为空");
            }
            if(CollectFiles.Count(c=>c.FileType == "0")<=0){
                yield return new ValidationResult("采集数据文件(FileType=0)为必传项并且只有一个文件");
            }
            if (CollectFiles.Count(c => c.FileType == "0") >1)
            {
                yield return new ValidationResult("采集数据文件(FileType=0)有且只能有一个文件");
            }
           
            //IEnumerable<ValidationResult> vResult = null;
            //foreach(var file in CollectFiles){
            //    vResult=((IValidatableObject)file).Validate(validationContext);
            //}
            //if (vResult != null && vResult.Count() >0)
            //{
            //    yield return vResult.First();
            //}
        }
    }
    /// <summary>
    /// 集采文件
    /// </summary>
    public class CollectFile : IValidatableObject
    {
        /// <summary>
        /// 文件类型
        /// 0：采集数据文件
        /// 1: 资料文档
        /// </summary>
         [Required(ErrorMessage = "FileType:(文件类型不能为空 0：采集数据文件 1: 资料文档)")]
        public string FileType { get; set; }
        /// <summary>
        /// 文件系统唯一标识
        /// </summary>
          [Required(ErrorMessage = "FileID:(文件ID不能为空)")]
        public string FileID { get; set; }
        /// <summary>
        /// 文件名称（全名称，包括后缀名）
        /// </summary>
         [Required(ErrorMessage = "FileName:(文件名称不能为空)")]
        public string FileName { get; set; }
        /// <summary>
        /// 文件描述
        /// </summary>
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!(FileType == "0" || FileType == "1"))
            {
                yield return new ValidationResult("FileType:(文件类型不能为空 0：采集数据文件 1: 资料文档)");
            }
        }
    }
}