using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Task_Menu_ExtMap : EntityTypeConfiguration<T_Task_Menu_Ext>
    {
        public T_Task_Menu_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderBy);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ParentBy)
                .IsRequired()
                .HasMaxLength(50);

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

            // Table & Column Mappings
            this.ToTable("T_Task_Menu_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentBy).HasColumnName("ParentBy");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.MenuText).HasColumnName("MenuText");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Oldurl).HasColumnName("Oldurl");
            this.Property(t => t.Menutype).HasColumnName("Menutype");
        }
    }
}
