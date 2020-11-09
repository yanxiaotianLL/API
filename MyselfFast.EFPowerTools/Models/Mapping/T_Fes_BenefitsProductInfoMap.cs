using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_BenefitsProductInfoMap : EntityTypeConfiguration<T_Fes_BenefitsProductInfo>
    {
        public T_Fes_BenefitsProductInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("T_Fes_BenefitsProductInfo");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.GroupFlag).HasColumnName("GroupFlag");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
