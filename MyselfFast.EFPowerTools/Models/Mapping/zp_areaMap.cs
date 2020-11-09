using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class zp_areaMap : EntityTypeConfiguration<zp_area>
    {
        public zp_areaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Aname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Contextinfo)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("zp_area");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Aname).HasColumnName("Aname");
            this.Property(t => t.Did).HasColumnName("Did");
            this.Property(t => t.Contextinfo).HasColumnName("Contextinfo");
        }
    }
}
