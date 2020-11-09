using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class TEMP_DEFAULT
    {
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Default_Value { get; set; }
        public string Constraint_Name { get; set; }
    }
}
