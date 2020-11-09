using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Exm_ProjectDictionary
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int Fid { get; set; }
        public int ProjectBeginTime { get; set; }
        public int PackageEndTime { get; set; }
        public int PayEndTime { get; set; }
        public int ProjectEndTime { get; set; }
        public System.DateTime EntryTime { get; set; }
    }
}
