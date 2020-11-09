using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class HM_DISCUZMap : EntityTypeConfiguration<HM_DISCUZ>
    {
        public HM_DISCUZMap()
        {
            // Primary Key
            this.HasKey(t => new { t.apikey, t.secret, t.url });

            // Properties
            this.Property(t => t.apikey)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.secret)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.url)
                .IsRequired()
                .HasMaxLength(27);

            // Table & Column Mappings
            this.ToTable("HM_DISCUZ");
            this.Property(t => t.apikey).HasColumnName("apikey");
            this.Property(t => t.secret).HasColumnName("secret");
            this.Property(t => t.url).HasColumnName("url");
        }
    }
}
