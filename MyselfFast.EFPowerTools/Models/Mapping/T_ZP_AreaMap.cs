using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_ZP_AreaMap : EntityTypeConfiguration<T_ZP_Area>
    {
        public T_ZP_AreaMap()
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
            this.ToTable("T_ZP_Area");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Aname).HasColumnName("Aname");
            this.Property(t => t.Did).HasColumnName("Did");
            this.Property(t => t.Contextinfo).HasColumnName("Contextinfo");
        }
    }
}
