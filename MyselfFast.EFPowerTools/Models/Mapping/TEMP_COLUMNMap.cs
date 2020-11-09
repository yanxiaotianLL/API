using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class TEMP_COLUMNMap : EntityTypeConfiguration<TEMP_COLUMN>
    {
        public TEMP_COLUMNMap()
        {
            // Primary Key
            this.HasKey(t => t.TABNAME);

            // Properties
            this.Property(t => t.TABNAME)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.COLNAME)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("TEMP_COLUMN");
            this.Property(t => t.TABNAME).HasColumnName("TABNAME");
            this.Property(t => t.COLNAME).HasColumnName("COLNAME");
        }
    }
}
