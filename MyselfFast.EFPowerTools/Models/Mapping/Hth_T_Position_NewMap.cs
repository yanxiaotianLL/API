using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_Position_NewMap : EntityTypeConfiguration<Hth_T_Position_New>
    {
        public Hth_T_Position_NewMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Level)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_Position_New");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
        }
    }
}
