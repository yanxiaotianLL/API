using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_JibieMap : EntityTypeConfiguration<Hm_Jibie>
    {
        public Hm_JibieMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Hm_Jibie");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
