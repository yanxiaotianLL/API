using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class X_SENDSMap : EntityTypeConfiguration<X_SENDS>
    {
        public X_SENDSMap()
        {
            // Primary Key
            this.HasKey(t => t.s);

            // Properties
            this.Property(t => t.VNO)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("X_SENDS");
            this.Property(t => t.VNO).HasColumnName("VNO");
            this.Property(t => t.s).HasColumnName("s");
        }
    }
}
