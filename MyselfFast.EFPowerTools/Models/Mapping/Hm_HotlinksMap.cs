using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_HotlinksMap : EntityTypeConfiguration<Hm_Hotlinks>
    {
        public Hm_HotlinksMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Picpath)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Hm_Hotlinks");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Picpath).HasColumnName("Picpath");
        }
    }
}
