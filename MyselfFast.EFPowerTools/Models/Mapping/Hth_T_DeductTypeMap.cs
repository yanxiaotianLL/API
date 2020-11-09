using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_DeductTypeMap : EntityTypeConfiguration<Hth_T_DeductType>
    {
        public Hth_T_DeductTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_DeductType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
