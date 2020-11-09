using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Admin_MenuMap : EntityTypeConfiguration<T_Fes_Admin_Menu>
    {
        public T_Fes_Admin_MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ParentOrder)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Orderby)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ShortName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Imgpath)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Urlpath)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.CreaterName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EditerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuPara)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("T_Fes_Admin_Menu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GUID).HasColumnName("GUID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.ParentOrder).HasColumnName("ParentOrder");
            this.Property(t => t.Orderby).HasColumnName("Orderby");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.Imgpath).HasColumnName("Imgpath");
            this.Property(t => t.Urlpath).HasColumnName("Urlpath");
            this.Property(t => t.Levelis).HasColumnName("Levelis");
            this.Property(t => t.Showtype).HasColumnName("Showtype");
            this.Property(t => t.Urladdid).HasColumnName("Urladdid");
            this.Property(t => t.Urladdguid).HasColumnName("Urladdguid");
            this.Property(t => t.IsInner).HasColumnName("IsInner");
            this.Property(t => t.HasChilds).HasColumnName("HasChilds");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.CreaterId).HasColumnName("CreaterId");
            this.Property(t => t.CreaterName).HasColumnName("CreaterName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EditerId).HasColumnName("EditerId");
            this.Property(t => t.EditerName).HasColumnName("EditerName");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
            this.Property(t => t.MenuPara).HasColumnName("MenuPara");
        }
    }
}
