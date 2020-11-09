using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_HK_OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
