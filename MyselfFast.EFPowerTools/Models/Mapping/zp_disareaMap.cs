using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class zp_disareaMap : EntityTypeConfiguration<zp_disarea>
    {
        public zp_disareaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Dname)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("zp_disarea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Dname).HasColumnName("Dname");
        }
    }
}
