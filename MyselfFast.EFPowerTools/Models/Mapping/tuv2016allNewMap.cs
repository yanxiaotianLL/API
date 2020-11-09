using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class tuv2016allNewMap : EntityTypeConfiguration<tuv2016allNew>
    {
        public tuv2016allNewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(50);

            this.Property(t => t.sex)
                .HasMaxLength(50);

            this.Property(t => t.cid)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.mobile)
                .HasMaxLength(50);

            this.Property(t => t.city)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tuv2016allNew");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.cid).HasColumnName("cid");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.mobile).HasColumnName("mobile");
            this.Property(t => t.city).HasColumnName("city");
        }
    }
}
