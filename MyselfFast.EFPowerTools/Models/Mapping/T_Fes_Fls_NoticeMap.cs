using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_NoticeMap : EntityTypeConfiguration<T_Fes_Fls_Notice>
    {
        public T_Fes_Fls_NoticeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Lanmu)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_Notice");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Pubdate).HasColumnName("Pubdate");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Lanmu).HasColumnName("Lanmu");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.Hitstime).HasColumnName("Hitstime");
        }
    }
}
