using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Sys_GuanggaoMap : EntityTypeConfiguration<T_Sys_Guanggao>
    {
        public T_Sys_GuanggaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Place);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Place)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Linkpath)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("T_Sys_Guanggao");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Place).HasColumnName("Place");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Linkpath).HasColumnName("Linkpath");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Tag).HasColumnName("Tag");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.Istot).HasColumnName("Istot");
            this.Property(t => t.Thishits).HasColumnName("Thishits");
            this.Property(t => t.Isshow).HasColumnName("Isshow");
            this.Property(t => t.Idx).HasColumnName("Idx");
        }
    }
}
