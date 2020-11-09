using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_LinksMap : EntityTypeConfiguration<T_Gds_Links>
    {
        public T_Gds_LinksMap()
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
            this.ToTable("T_Gds_Links");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Picpath).HasColumnName("Picpath");
        }
    }
}
