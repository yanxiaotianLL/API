using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Member
    {
        public int ID { get; set; }
        public Nullable<int> RegistrationID { get; set; }
        public string Name { get; set; }
        public string IDCard { get; set; }
        public string Tel { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Type { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public Nullable<int> Age { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}
