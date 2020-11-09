using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Dan_Interface_Note
    {
        public int Id { get; set; }
        public int InterType { get; set; }
        public long piCallRecId { get; set; }
        public string Prams { get; set; }
        public int Status { get; set; }
        public System.DateTime Gendate { get; set; }
    }
}
