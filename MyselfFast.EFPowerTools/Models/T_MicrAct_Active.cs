using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_MicrAct_Active
    {
        public int ID { get; set; }
        public int Fid { get; set; }
        public int ParentID { get; set; }
        public string Introduction { get; set; }
        public string ActiveName { get; set; }
        public string ActiveContent { get; set; }
        public System.DateTime Pubtime { get; set; }
        public int Status { get; set; }
        public int Foruse { get; set; }
        public int Ischarge { get; set; }
        public int Regnum { get; set; }
        public int Personnum { get; set; }
        public decimal Val { get; set; }
        public int Regbuttonshow { get; set; }
        public string Activetime { get; set; }
        public int Ontop { get; set; }
        public System.DateTime Begindate { get; set; }
        public System.DateTime Enddate { get; set; }
        public string MicrPic { get; set; }
        public string TurnPic { get; set; }
        public int Isemp { get; set; }
        public int Iswenti { get; set; }
        public int IsChildren { get; set; }
        public int Isxianchang { get; set; }
        public int Isverify { get; set; }
        public string AgreementContent { get; set; }
        public string ActiveAddress { get; set; }
        public string ApplyChannel { get; set; }
        public int IsPayOnline { get; set; }
        public string ActivePrice { get; set; }
        public decimal WelfarePrice { get; set; }
        public decimal WelfareFamilyPrice { get; set; }
        public Nullable<decimal> NoEmployeePrice { get; set; }
        public decimal NoWelfareFamilyPrice { get; set; }
        public decimal NoWelfareChildPrice { get; set; }
        public decimal WelfareChildPrice { get; set; }
        public int ActiveType { get; set; }
        public int ActiveFrom { get; set; }
        public bool IsIndexDisplay { get; set; }
        public int surplusNum { get; set; }
        public bool IsDelete { get; set; }
        public bool IsPromoCode { get; set; }
        public Nullable<int> Isshowinlist { get; set; }
        public int ReadNum { get; set; }
        public int PointOfPraiseNum { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public string Topic { get; set; }
        public bool IsSubActive { get; set; }
        public bool IsCaryChildren { get; set; }
        public Nullable<int> IsShowBillMsg { get; set; }
        public Nullable<decimal> DepositMoney { get; set; }
        public Nullable<int> IsHavingDeposit { get; set; }
        public decimal FareCash { get; set; }
        public decimal FameCash { get; set; }
        public decimal FChildCash { get; set; }
        public decimal NEmpCash { get; set; }
        public decimal NFameCash { get; set; }
        public decimal NFChildCash { get; set; }
        public int OrderBy { get; set; }
        public int IsCheckCardAndPwd { get; set; }
        public int HealthActiveType { get; set; }
    }
}
