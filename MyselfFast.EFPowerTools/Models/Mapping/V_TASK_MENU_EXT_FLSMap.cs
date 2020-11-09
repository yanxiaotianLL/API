using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_TASK_MENU_EXT_FLSMap : EntityTypeConfiguration<V_TASK_MENU_EXT_FLS>
    {
        public V_TASK_MENU_EXT_FLSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Fid, t.ParentBy, t.Id, t.OrderBy, t.MenuText, t.Url, t.Oldurl, t.Menutype });

            // Properties
            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OrderBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuText)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Oldurl)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Menutype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_TASK_MENU_EXT_FLS");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ParentBy).HasColumnName("ParentBy");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.MenuText).HasColumnName("MenuText");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Oldurl).HasColumnName("Oldurl");
            this.Property(t => t.Menutype).HasColumnName("Menutype");
        }
    }
}
