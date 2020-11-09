using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_ArticleMap : EntityTypeConfiguration<T_Article>
    {
        public T_ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.StaticUrl)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.AdminName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Article");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StaticUrl).HasColumnName("StaticUrl");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.AdminName).HasColumnName("AdminName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
