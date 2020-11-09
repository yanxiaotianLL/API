using System;
using System.Collections.Generic;

namespace FescoFast.EFPowerTools.Models
{
    public partial class T_GJJZQ_Apply
    {
        public int Id { get; set; }
        public int Hno { get; set; }
        public int UserId { get; set; }
        public int IsOnsite { get; set; }
        public int Sort { get; set; }
        public string ApplyNo { get; set; }
        public string ApplyName { get; set; }
        public string PetitionerName { get; set; }
        public string PetitionerCardId { get; set; }
        public string PetitionerCard { get; set; }
        public string PetitionerIsPay { get; set; }
        public string ProvidentAddress { get; set; }
        public string CardBank { get; set; }
        public string CardNo { get; set; }
        public string PetitionerMarriage { get; set; }
        public string PetitionerPhone { get; set; }
        public string Contact { get; set; }
        public string AuthoritySelf { get; set; }
        public string SpouseName { get; set; }
        public string SpouseCardId { get; set; }
        public string SpouseCard { get; set; }
        public string SpidIssued { get; set; }
        public string LookPassword { get; set; }
        public string HouseNature { get; set; }
        public string ExtractReason { get; set; }
        public string HousePurchase { get; set; }
        public string ContractNO { get; set; }
        public string Houseowner { get; set; }
        public string HouseAdrProvince { get; set; }
        public string HouseAdrCity { get; set; }
        public string HouseAdrCounty { get; set; }
        public string HouseAdrStreet { get; set; }
        public string HouseAdrPlot { get; set; }
        public string HouseAdrBuilding { get; set; }
        public string HouseAdrUnit { get; set; }
        public string HouseAdrFloor { get; set; }
        public string HouseNo { get; set; }
        public decimal AfterExpend { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal HousingExpend { get; set; }
        public decimal BuyHoSpend { get; set; }
        public decimal RentHoSpend { get; set; }
        public decimal ApplyFundMoney { get; set; }
        public decimal ExtractFundMoney { get; set; }
        public decimal PropertyFundMoney { get; set; }
        public decimal BillAllMoney { get; set; }
        public decimal BoarderFundLimit { get; set; }
        public decimal SelfBuildFundLimit { get; set; }
        public decimal OtherExpenses { get; set; }
        public string IssueDepartment { get; set; }
        public string PropertyDepartment { get; set; }
        public string SelfbuiltDepartment { get; set; }
        public System.DateTime LeaseBegin { get; set; }
        public System.DateTime LeaseEnd { get; set; }
        public decimal FundCapture { get; set; }
        public decimal RentMonth { get; set; }
        public string ApplyRelationship { get; set; }
        public decimal OwnAmout { get; set; }
        public decimal PersonCostAmount { get; set; }
        public string StateAddressSort { get; set; }
        public string StateAddress { get; set; }
        public string StateAddressCode { get; set; }
        public string IsApplyFund { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Page { get; set; }
        public System.DateTime SubmitTime { get; set; }
        public Nullable<int> ApplyItem { get; set; }
        public string OtherItem { get; set; }
        public string OtherMaterials { get; set; }
        public string CensusRegister { get; set; }
        public string SellPerson { get; set; }
        public string LoanContractNo { get; set; }
        public Nullable<System.DateTime> LoanTime { get; set; }
        public string ItemName { get; set; }
        public string LicenseNo { get; set; }
        public string ApproveOrganization { get; set; }
        public Nullable<int> LoanPeriod { get; set; }
        public Nullable<int> RelationOfOwner { get; set; }
        public Nullable<decimal> BuildingArea { get; set; }
        public Nullable<decimal> HouseMony { get; set; }
        public bool IsDelete { get; set; }
    }
}
