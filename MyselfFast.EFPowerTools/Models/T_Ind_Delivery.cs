using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_Delivery
    {
        public int Id { get; set; }
        public int DeliveryType { get; set; }
        public int Type { get; set; }
        public int FesId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string DeliveryCompany { get; set; }
        public string DeliveryNum { get; set; }
        public string DeliveryAddress { get; set; }
        public int ActionFesId { get; set; }
        public string ActionPeopleName { get; set; }
        public int IsFinished { get; set; }
        public int AddressType { get; set; }
        public int FormalityId { get; set; }
    }
}
