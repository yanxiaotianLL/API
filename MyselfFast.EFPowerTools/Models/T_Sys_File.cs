using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sys_File
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public string TableName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public System.DateTime UpLoadDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int IsValue { get; set; }
        public string FileName { get; set; }
        public string FileFormat { get; set; }
        public int FormalityId { get; set; }
        public int ElecMatSource { get; set; }
        public int Type { get; set; }
        public int FileNo { get; set; }
        public int RecordFlowId { get; set; }
        public string CardId { get; set; }
        public string PhoneSysterm { get; set; }
        public string MergePicId { get; set; }
        public string RevisePicId { get; set; }
        public string FileId { get; set; }
    }
}
