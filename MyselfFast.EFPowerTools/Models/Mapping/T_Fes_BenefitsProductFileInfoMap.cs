using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_BenefitsProductFileInfoMap : EntityTypeConfiguration<T_Fes_BenefitsProductFileInfo>
    {
        public T_Fes_BenefitsProductFileInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BJFileName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.BJFileUrl)
                .IsRequired()
                .HasMaxLength(521);

            this.Property(t => t.WDFileName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.WDFileUrl)
                .IsRequired()
                .HasMaxLength(521);

            // Table & Column Mappings
            this.ToTable("T_Fes_BenefitsProductFileInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.BJFileName).HasColumnName("BJFileName");
            this.Property(t => t.BJFileUrl).HasColumnName("BJFileUrl");
            this.Property(t => t.BJFileType).HasColumnName("BJFileType");
            this.Property(t => t.WDFileName).HasColumnName("WDFileName");
            this.Property(t => t.WDFileUrl).HasColumnName("WDFileUrl");
            this.Property(t => t.WDFileType).HasColumnName("WDFileType");
        }
    }
}
