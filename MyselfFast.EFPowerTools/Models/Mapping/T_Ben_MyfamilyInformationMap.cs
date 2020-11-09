using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ben_MyfamilyInformationMap : EntityTypeConfiguration<T_Ben_MyfamilyInformation>
    {
        public T_Ben_MyfamilyInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HouseholdRegister)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.LiveAddress)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.CertificateCode)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.PoliticalStatus)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HouseholeType)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.RelationShip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Bankcardname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Banktype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bankcardno)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Ben_MyfamilyInformation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FesID).HasColumnName("FesID");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.HouseholdRegister).HasColumnName("HouseholdRegister");
            this.Property(t => t.LiveAddress).HasColumnName("LiveAddress");
            this.Property(t => t.CertificateCode).HasColumnName("CertificateCode");
            this.Property(t => t.PoliticalStatus).HasColumnName("PoliticalStatus");
            this.Property(t => t.HouseholeType).HasColumnName("HouseholeType");
            this.Property(t => t.RelationShip).HasColumnName("RelationShip");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.LastModifyTime).HasColumnName("LastModifyTime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.CertificateType).HasColumnName("CertificateType");
            this.Property(t => t.Bankcardname).HasColumnName("Bankcardname");
            this.Property(t => t.Banktype).HasColumnName("Banktype");
            this.Property(t => t.Bankcardno).HasColumnName("Bankcardno");
        }
    }
}
