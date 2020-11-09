using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_S_PackMap : EntityTypeConfiguration<Hth_S_Pack>
    {
        public Hth_S_PackMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Number)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderIds)
                .IsRequired()
                .HasMaxLength(8000);

            this.Property(t => t.PNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_S_Pack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.SysUser).HasColumnName("SysUser");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.OrderIds).HasColumnName("OrderIds");
            this.Property(t => t.PNumber).HasColumnName("PNumber");
            this.Property(t => t.Operuser).HasColumnName("Operuser");
        }
    }
}
