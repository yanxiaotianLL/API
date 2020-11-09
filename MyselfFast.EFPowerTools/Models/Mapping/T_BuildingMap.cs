using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_BuildingMap : EntityTypeConfiguration<T_Building>
    {
        public T_BuildingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Qu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Building)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pinyin)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Area)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Quen)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Building");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Qu).HasColumnName("Qu");
            this.Property(t => t.Building).HasColumnName("Building");
            this.Property(t => t.Pinyin).HasColumnName("Pinyin");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Quen).HasColumnName("Quen");
        }
    }
}
