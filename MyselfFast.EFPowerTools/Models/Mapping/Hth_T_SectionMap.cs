using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_SectionMap : EntityTypeConfiguration<Hth_T_Section>
    {
        public Hth_T_SectionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Section");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Content).HasColumnName("Content");
        }
    }
}
