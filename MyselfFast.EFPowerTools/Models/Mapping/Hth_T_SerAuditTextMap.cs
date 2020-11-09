using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_SerAuditTextMap : EntityTypeConfiguration<Hth_T_SerAuditText>
    {
        public Hth_T_SerAuditTextMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_SerAuditText");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ForShowDiff).HasColumnName("ForShowDiff");
        }
    }
}
