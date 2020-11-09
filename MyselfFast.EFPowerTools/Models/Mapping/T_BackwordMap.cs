using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_BackwordMap : EntityTypeConfiguration<T_Backword>
    {
        public T_BackwordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Sort, t.Title, t.Context });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sort)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Context)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_Backword");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Context).HasColumnName("Context");
        }
    }
}
