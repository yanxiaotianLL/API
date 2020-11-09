using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class MenutempMap : EntityTypeConfiguration<Menutemp>
    {
        public MenutempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.列_0, t.列_1, t.列_2, t.列_3, t.列_4, t.列_5, t.列_6 });

            // Properties
            this.Property(t => t.列_0)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_5)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.列_6)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Menutemp");
            this.Property(t => t.列_0).HasColumnName("列 0");
            this.Property(t => t.列_1).HasColumnName("列 1");
            this.Property(t => t.列_2).HasColumnName("列 2");
            this.Property(t => t.列_3).HasColumnName("列 3");
            this.Property(t => t.列_4).HasColumnName("列 4");
            this.Property(t => t.列_5).HasColumnName("列 5");
            this.Property(t => t.列_6).HasColumnName("列 6");
        }
    }
}
