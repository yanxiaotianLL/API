using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class TEMP_DEFAULTMap : EntityTypeConfiguration<TEMP_DEFAULT>
    {
        public TEMP_DEFAULTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Table_Name, t.Constraint_Name });

            // Properties
            this.Property(t => t.Table_Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Column_Name)
                .HasMaxLength(128);

            this.Property(t => t.Constraint_Name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TEMP_DEFAULT");
            this.Property(t => t.Table_Name).HasColumnName("Table Name");
            this.Property(t => t.Column_Name).HasColumnName("Column Name");
            this.Property(t => t.Default_Value).HasColumnName("Default Value");
            this.Property(t => t.Constraint_Name).HasColumnName("Constraint Name");
        }
    }
}
