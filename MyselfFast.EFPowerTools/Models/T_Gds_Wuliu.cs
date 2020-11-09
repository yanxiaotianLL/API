using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Wuliu
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Addr { get; set; }
        public string Postcode { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public int State { get; set; }
        public System.DateTime Gendate { get; set; }
        public string Opuser { get; set; }
        public string KD100CODE { get; set; }
        public string KDBIRDCODE { get; set; }
    }
}
