using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Art_ArticleMap : EntityTypeConfiguration<T_Art_Article>
    {
        public T_Art_ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Author)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.ArtType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Art_Article");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Colid).HasColumnName("Colid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Pubdate).HasColumnName("Pubdate");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Arcst).HasColumnName("Arcst");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.Hitstime).HasColumnName("Hitstime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ArtType).HasColumnName("ArtType");
        }
    }
}
