using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Sohu_Dan_ReTransfer
    {
        public int Id { get; set; }
        public string SH_EB_ORDER_ID { get; set; }
        public Nullable<int> SH_MAIN_SPEC_NAME { get; set; }
        public Nullable<int> SH_SUB_SPEC_NAME { get; set; }
        public Nullable<long> SH_PRODUCT_ID { get; set; }
        public int State { get; set; }
        public System.DateTime Gendate { get; set; }
    }
}
