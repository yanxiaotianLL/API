using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_For_Deleted
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public string Fname { get; set; }
        public int Hno { get; set; }
        public string Password { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Gno { get; set; }
        public int CardType { get; set; }
        public string CardId { get; set; }
        public string Sex { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Verify { get; set; }
        public int SafeVerify { get; set; }
        public bool Isdeleted { get; set; }
        public System.DateTime DeleteTime { get; set; }
    }
}
