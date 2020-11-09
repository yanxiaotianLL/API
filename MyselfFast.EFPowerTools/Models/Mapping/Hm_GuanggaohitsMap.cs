using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_GuanggaohitsMap : EntityTypeConfiguration<Hm_Guanggaohits>
    {
        public Hm_GuanggaohitsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(228);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Place)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("Hm_Guanggaohits");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Place).HasColumnName("Place");
            this.Property(t => t.Thishits).HasColumnName("Thishits");
            this.Property(t => t.Subdate).HasColumnName("Subdate");
        }
    }
}
