using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_ApplyMap : EntityTypeConfiguration<T_GJJZQ_Apply>
    {
        public T_GJJZQ_ApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ApplyName)
                .HasMaxLength(100);

            this.Property(t => t.PetitionerName)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.PetitionerCardId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PetitionerCard)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PetitionerIsPay)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ProvidentAddress)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.CardBank)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PetitionerMarriage)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PetitionerPhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Contact)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AuthoritySelf)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpouseName)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.SpouseCardId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SpouseCard)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SpidIssued)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LookPassword)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.HouseNature)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExtractReason)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HousePurchase)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContractNO)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Houseowner)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HouseAdrProvince)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HouseAdrCity)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HouseAdrCounty)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HouseAdrStreet)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HouseAdrPlot)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.HouseAdrBuilding)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.HouseAdrUnit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HouseAdrFloor)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.HouseNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IssueDepartment)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PropertyDepartment)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SelfbuiltDepartment)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApplyRelationship)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.StateAddressSort)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.StateAddress)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.StateAddressCode)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.IsApplyFund)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Page)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OtherItem)
                .HasMaxLength(500);

            this.Property(t => t.OtherMaterials)
                .HasMaxLength(3000);

            this.Property(t => t.CensusRegister)
                .HasMaxLength(150);

            this.Property(t => t.SellPerson)
                .HasMaxLength(100);

            this.Property(t => t.LoanContractNo)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(150);

            this.Property(t => t.LicenseNo)
                .HasMaxLength(50);

            this.Property(t => t.ApproveOrganization)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_Apply");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.IsOnsite).HasColumnName("IsOnsite");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.ApplyName).HasColumnName("ApplyName");
            this.Property(t => t.PetitionerName).HasColumnName("PetitionerName");
            this.Property(t => t.PetitionerCardId).HasColumnName("PetitionerCardId");
            this.Property(t => t.PetitionerCard).HasColumnName("PetitionerCard");
            this.Property(t => t.PetitionerIsPay).HasColumnName("PetitionerIsPay");
            this.Property(t => t.ProvidentAddress).HasColumnName("ProvidentAddress");
            this.Property(t => t.CardBank).HasColumnName("CardBank");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PetitionerMarriage).HasColumnName("PetitionerMarriage");
            this.Property(t => t.PetitionerPhone).HasColumnName("PetitionerPhone");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.AuthoritySelf).HasColumnName("AuthoritySelf");
            this.Property(t => t.SpouseName).HasColumnName("SpouseName");
            this.Property(t => t.SpouseCardId).HasColumnName("SpouseCardId");
            this.Property(t => t.SpouseCard).HasColumnName("SpouseCard");
            this.Property(t => t.SpidIssued).HasColumnName("SpidIssued");
            this.Property(t => t.LookPassword).HasColumnName("LookPassword");
            this.Property(t => t.HouseNature).HasColumnName("HouseNature");
            this.Property(t => t.ExtractReason).HasColumnName("ExtractReason");
            this.Property(t => t.HousePurchase).HasColumnName("HousePurchase");
            this.Property(t => t.ContractNO).HasColumnName("ContractNO");
            this.Property(t => t.Houseowner).HasColumnName("Houseowner");
            this.Property(t => t.HouseAdrProvince).HasColumnName("HouseAdrProvince");
            this.Property(t => t.HouseAdrCity).HasColumnName("HouseAdrCity");
            this.Property(t => t.HouseAdrCounty).HasColumnName("HouseAdrCounty");
            this.Property(t => t.HouseAdrStreet).HasColumnName("HouseAdrStreet");
            this.Property(t => t.HouseAdrPlot).HasColumnName("HouseAdrPlot");
            this.Property(t => t.HouseAdrBuilding).HasColumnName("HouseAdrBuilding");
            this.Property(t => t.HouseAdrUnit).HasColumnName("HouseAdrUnit");
            this.Property(t => t.HouseAdrFloor).HasColumnName("HouseAdrFloor");
            this.Property(t => t.HouseNo).HasColumnName("HouseNo");
            this.Property(t => t.AfterExpend).HasColumnName("AfterExpend");
            this.Property(t => t.LoanAmount).HasColumnName("LoanAmount");
            this.Property(t => t.HousingExpend).HasColumnName("HousingExpend");
            this.Property(t => t.BuyHoSpend).HasColumnName("BuyHoSpend");
            this.Property(t => t.RentHoSpend).HasColumnName("RentHoSpend");
            this.Property(t => t.ApplyFundMoney).HasColumnName("ApplyFundMoney");
            this.Property(t => t.ExtractFundMoney).HasColumnName("ExtractFundMoney");
            this.Property(t => t.PropertyFundMoney).HasColumnName("PropertyFundMoney");
            this.Property(t => t.BillAllMoney).HasColumnName("BillAllMoney");
            this.Property(t => t.BoarderFundLimit).HasColumnName("BoarderFundLimit");
            this.Property(t => t.SelfBuildFundLimit).HasColumnName("SelfBuildFundLimit");
            this.Property(t => t.OtherExpenses).HasColumnName("OtherExpenses");
            this.Property(t => t.IssueDepartment).HasColumnName("IssueDepartment");
            this.Property(t => t.PropertyDepartment).HasColumnName("PropertyDepartment");
            this.Property(t => t.SelfbuiltDepartment).HasColumnName("SelfbuiltDepartment");
            this.Property(t => t.LeaseBegin).HasColumnName("LeaseBegin");
            this.Property(t => t.LeaseEnd).HasColumnName("LeaseEnd");
            this.Property(t => t.FundCapture).HasColumnName("FundCapture");
            this.Property(t => t.RentMonth).HasColumnName("RentMonth");
            this.Property(t => t.ApplyRelationship).HasColumnName("ApplyRelationship");
            this.Property(t => t.OwnAmout).HasColumnName("OwnAmout");
            this.Property(t => t.PersonCostAmount).HasColumnName("PersonCostAmount");
            this.Property(t => t.StateAddressSort).HasColumnName("StateAddressSort");
            this.Property(t => t.StateAddress).HasColumnName("StateAddress");
            this.Property(t => t.StateAddressCode).HasColumnName("StateAddressCode");
            this.Property(t => t.IsApplyFund).HasColumnName("IsApplyFund");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Page).HasColumnName("Page");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
            this.Property(t => t.ApplyItem).HasColumnName("ApplyItem");
            this.Property(t => t.OtherItem).HasColumnName("OtherItem");
            this.Property(t => t.OtherMaterials).HasColumnName("OtherMaterials");
            this.Property(t => t.CensusRegister).HasColumnName("CensusRegister");
            this.Property(t => t.SellPerson).HasColumnName("SellPerson");
            this.Property(t => t.LoanContractNo).HasColumnName("LoanContractNo");
            this.Property(t => t.LoanTime).HasColumnName("LoanTime");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.LicenseNo).HasColumnName("LicenseNo");
            this.Property(t => t.ApproveOrganization).HasColumnName("ApproveOrganization");
            this.Property(t => t.LoanPeriod).HasColumnName("LoanPeriod");
            this.Property(t => t.RelationOfOwner).HasColumnName("RelationOfOwner");
            this.Property(t => t.BuildingArea).HasColumnName("BuildingArea");
            this.Property(t => t.HouseMony).HasColumnName("HouseMony");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
