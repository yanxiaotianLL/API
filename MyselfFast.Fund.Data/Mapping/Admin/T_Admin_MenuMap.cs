//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_MenuMap : myselfFastEntityTypeConfiguration<T_Admin_Menu>
    {
        public T_Admin_MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MenuName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuDescription)
                .HasMaxLength(500);

            this.Property(t => t.Url)
                .HasMaxLength(100);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.UpdateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.Icon)
                .HasMaxLength(100);

            this.Property(t => t.MenuCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ControllerName)
                .HasMaxLength(50);

            this.Property(t => t.ActionName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Admin_Menu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.MenuDescription).HasColumnName("MenuDescription");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            //this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.UpdateAdmin).HasColumnName("UpdateAdmin");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.MenuCode).HasColumnName("MenuCode");
            this.Property(t => t.IsLeaf).HasColumnName("IsLeaf");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
        }
    }
}

