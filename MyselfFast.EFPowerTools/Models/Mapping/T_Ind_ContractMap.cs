using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_ContractMap : EntityTypeConfiguration<T_Ind_Contract>
    {
        public T_Ind_ContractMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ContractAddress)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.LeavingCertificateDetails)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ContractDetails)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Ind_Contract");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.SignType).HasColumnName("SignType");
            this.Property(t => t.DeliveryId).HasColumnName("DeliveryId");
            this.Property(t => t.IsMerge).HasColumnName("IsMerge");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ContractType).HasColumnName("ContractType");
            this.Property(t => t.ContractAddress).HasColumnName("ContractAddress");
            this.Property(t => t.LeavingCertificateStatus).HasColumnName("LeavingCertificateStatus");
            this.Property(t => t.LeavingCertificateDetails).HasColumnName("LeavingCertificateDetails");
            this.Property(t => t.ContractStatus).HasColumnName("ContractStatus");
            this.Property(t => t.ContractDetails).HasColumnName("ContractDetails");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
        }
    }
}
