using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_Grade
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string UserName { get; set; }
        public int Hno { get; set; }
        public int JigouId { get; set; }
        public int Environment { get; set; }
        public int Service { get; set; }
        public int Averagetime { get; set; }
        public int Doctorstandard { get; set; }
        public int Breakfast { get; set; }
        public string Comment { get; set; }
        public System.DateTime Createtime { get; set; }
        public decimal Average { get; set; }
        public string CardNumber { get; set; }
    }
}
