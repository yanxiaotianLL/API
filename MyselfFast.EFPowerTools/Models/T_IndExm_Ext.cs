using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_IndExm_Ext
    {
        public int ID { get; set; }
        public int FesId { get; set; }
        public int DetailID { get; set; }
        public int FormalityID { get; set; }
        public bool HasOnline { get; set; }
        public bool HasUpload { get; set; }
        public bool HasConfirmService { get; set; }
        public int NewSysPID { get; set; }
        public int PackageId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
