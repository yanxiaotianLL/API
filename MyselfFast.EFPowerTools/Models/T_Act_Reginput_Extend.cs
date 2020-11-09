using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Reginput_Extend
    {
        public int Id { get; set; }
        public int Activeid { get; set; }
        public int InputType { get; set; }
        public string InputLabel { get; set; }
        public string InputValue { get; set; }
        public bool IsRequired { get; set; }
        public bool Enable { get; set; }
        public int InputSort { get; set; }
        public int PersonIndex { get; set; }
        public string Description { get; set; }
        public int FieldType { get; set; }
        public bool Isdelete { get; set; }
    }
}
