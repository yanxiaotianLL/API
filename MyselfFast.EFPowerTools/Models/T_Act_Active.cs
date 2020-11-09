using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Act_Active
    {
        public int Id { get; set; }
        public Nullable<int> fid { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
        public string Content { get; set; }
        public System.DateTime Pubtime { get; set; }
        public string Pic { get; set; }
        public string Bigpic { get; set; }
        public int Status { get; set; }
        public int Foruse { get; set; }
        public int Ischarge { get; set; }
        public int Type { get; set; }
        public int Regnum { get; set; }
        public decimal Val { get; set; }
        public int Regbuttonshow { get; set; }
        public string Activetime { get; set; }
        public int Ontop { get; set; }
        public System.DateTime Begindate { get; set; }
        public System.DateTime Enddate { get; set; }
        public int Sendtype { get; set; }
        public int Isshowinlist { get; set; }
        public string Accountno { get; set; }
        public int Clubid { get; set; }
        public int Isemp { get; set; }
        public int Iswenti { get; set; }
        public int Isxianchang { get; set; }
        public int Pubtype { get; set; }
        public decimal Limitwenti { get; set; }
        public int Isverify { get; set; }
        public bool IsIndexDisplay { get; set; }
        public int Personnum { get; set; }
        public int surplusNum { get; set; }
        public bool Isdelete { get; set; }
    }
}
