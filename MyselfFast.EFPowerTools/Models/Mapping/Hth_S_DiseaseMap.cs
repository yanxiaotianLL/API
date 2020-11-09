using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_S_DiseaseMap : EntityTypeConfiguration<Hth_S_Disease>
    {
        public Hth_S_DiseaseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SysUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pinyin)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Hth_S_Disease");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.SysUser).HasColumnName("SysUser");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Pinyin).HasColumnName("Pinyin");
        }
    }
}
