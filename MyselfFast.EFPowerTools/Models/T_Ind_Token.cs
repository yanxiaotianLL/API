using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Token
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int TakeTokenType { get; set; }
        public string CurrentPlace { get; set; }
        public string DeliveryAddress { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DeliveryId { get; set; }
        public int IsMerge { get; set; }
        public int Status { get; set; }
        public int DeliveryAddType { get; set; }
        public int FormalityId { get; set; }
    }
}
