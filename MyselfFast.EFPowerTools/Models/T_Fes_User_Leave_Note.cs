using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Leave_Note
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public int Fid { get; set; }
        public int OperType { get; set; }
        public System.DateTime OperDate { get; set; }
        public int Operid { get; set; }
        public string OperName { get; set; }
    }
}
