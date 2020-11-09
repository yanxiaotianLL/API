using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_Fes_User_Ext
    {
        public int Id { get; set; }
        public int Fesid { get; set; }
        public System.DateTime Pborth { get; set; }
        public System.DateTime Mborth { get; set; }
        public System.DateTime Lborth { get; set; }
        public System.DateTime Sborth { get; set; }
        public string Native { get; set; }
        public string Addrdetail { get; set; }
        public string Location { get; set; }
        public int ProvinceId { get; set; }
        public string Province { get; set; }
        public int XianId { get; set; }
        public string Xian { get; set; }
        public string Tel { get; set; }
        public string Yewubu { get; set; }
        public string YewubuUser { get; set; }
        public string Msn { get; set; }
        public string Qq { get; set; }
        public string Lov { get; set; }
        public string Postcode { get; set; }
        public string Depart { get; set; }
        public string Grade { get; set; }
        public int Workyears { get; set; }
        public bool Hasboys { get; set; }
        public string busiCustNo { get; set; }
        public string conNo { get; set; }
        public string MedicalPosition { get; set; }
        public string Img { get; set; }
        public string Temp_Jd { get; set; }
        public Nullable<System.DateTime> Verifydate { get; set; }
        public Nullable<bool> Serisbinding { get; set; }
        public Nullable<int> Serbindingdate { get; set; }
        public long Orderid { get; set; }
        public Nullable<System.DateTime> Sbimagesdate { get; set; }
        public int Type { get; set; }
        public int RecordFlowId { get; set; }
        public int ElecMatSource { get; set; }
        public System.DateTime Iddate { get; set; }
        public int CradRecordFlowId { get; set; }
        public string UserYewubu { get; set; }
        public string UserYewubuUser { get; set; }
        public int custId { get; set; }
        public string custName { get; set; }
        public int busiCustId { get; set; }
        public string busiCustName { get; set; }
        public int conId { get; set; }
        public string conName { get; set; }
        public int acceId { get; set; }
        public string acceName { get; set; }
    }
}
