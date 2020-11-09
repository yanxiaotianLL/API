using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_AppointtedayMap : EntityTypeConfiguration<T_Act_Appointteday>
    {
        public T_Act_AppointtedayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Str1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Str2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Str3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dept)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Appointteday");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Teday).HasColumnName("Teday");
            this.Property(t => t.Isright).HasColumnName("Isright");
            this.Property(t => t.Str1).HasColumnName("Str1");
            this.Property(t => t.Str2).HasColumnName("Str2");
            this.Property(t => t.Str3).HasColumnName("Str3");
            this.Property(t => t.Int1).HasColumnName("Int1");
            this.Property(t => t.Int2).HasColumnName("Int2");
            this.Property(t => t.Int3).HasColumnName("Int3");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.Dept).HasColumnName("Dept");
        }
    }
}
