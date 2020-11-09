using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Onl_TmpMap : EntityTypeConfiguration<T_Onl_Tmp>
    {
        public T_Onl_TmpMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Classify)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Temp)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Onl_Tmp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MTmpId).HasColumnName("MTmpId");
            this.Property(t => t.Classify).HasColumnName("Classify");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Temp).HasColumnName("Temp");
        }
    }
}
