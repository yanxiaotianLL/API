using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_ModifyRecord
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> ImageId { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public int AdminId { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
