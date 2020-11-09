using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_PositionMap : EntityTypeConfiguration<Hth_T_Position>
    {
        public Hth_T_PositionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("Hth_T_Position");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
