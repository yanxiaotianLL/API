using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Gds_Gys
    {
        public int Id { get; set; }
        public string Gname { get; set; }
        public string Gcode { get; set; }
        public string Gaddress { get; set; }
        public string Gpost { get; set; }
        public string Gcontact { get; set; }
        public string Gtel { get; set; }
        public string Gphone { get; set; }
        public string Gfax { get; set; }
        public string Gemail { get; set; }
        public string Gheadway { get; set; }
        public int Gcycle { get; set; }
        public int Gcycledate { get; set; }
        public System.DateTime Gcondate { get; set; }
        public System.DateTime Gcondateend { get; set; }
        public int Gremindday { get; set; }
        public string Gbuslic { get; set; }
        public string Gbuslic_Ser { get; set; }
        public string Ginstcode { get; set; }
        public string Ginstcode_Ser { get; set; }
        public string Gcontract { get; set; }
        public string Gcontract_Ser { get; set; }
        public string Gplacelist_Ser { get; set; }
        public string Gother_Ser { get; set; }
        public string Gsource { get; set; }
        public System.DateTime Logtime { get; set; }
        public string Logip { get; set; }
        public int State { get; set; }
        public bool Isdelete { get; set; }
        public string JianCheng { get; set; }
        public string Ename { get; set; }
        public int Mid { get; set; }
    }
}
