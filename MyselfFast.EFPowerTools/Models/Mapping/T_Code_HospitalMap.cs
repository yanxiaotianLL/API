using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Code_HospitalMap : EntityTypeConfiguration<T_Code_Hospital>
    {
        public T_Code_HospitalMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Xinxihebing)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Bianma)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Quxian)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Leibie)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Dengji)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Pinyin)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Jianpin)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Code_Hospital");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Xinxihebing).HasColumnName("Xinxihebing");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Bianma).HasColumnName("Bianma");
            this.Property(t => t.Quxian).HasColumnName("Quxian");
            this.Property(t => t.Leibie).HasColumnName("Leibie");
            this.Property(t => t.Dengji).HasColumnName("Dengji");
            this.Property(t => t.Pinyin).HasColumnName("Pinyin");
            this.Property(t => t.Jianpin).HasColumnName("Jianpin");
        }
    }
}
