using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class Hth_T_Deduct
    {
        public int ID { get; set; }
        public int DType { get; set; }
        public double Amount { get; set; }
        public int Drug { get; set; }
        public int ImgId { get; set; }
        public int State { get; set; }
        public double Proportion { get; set; }
        public string Note { get; set; }
        public string DrugName { get; set; }
    }
}
