using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Ind_EmployeeCardFile
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int SubmitFileType { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }
    }
}
