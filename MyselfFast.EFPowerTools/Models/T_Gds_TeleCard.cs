using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_TeleCard
    {
        public int ID { get; set; }
        public string SERIALNUM { get; set; }
        public string CLAIMCODE { get; set; }
        public long HID { get; set; }
        public int Pubid { get; set; }
        public int STATE { get; set; }
        public System.DateTime EXPIRATIONDATE { get; set; }
        public string LAIYUAN { get; set; }
        public int LINKID { get; set; }
        public int Tailid { get; set; }
        public int Fid { get; set; }
    }
}
