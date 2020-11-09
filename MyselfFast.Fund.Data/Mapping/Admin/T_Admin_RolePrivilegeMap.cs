//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_RolePrivilegeMap : myselfFastEntityTypeConfiguration<T_Admin_RolePrivilege>
    {
        public T_Admin_RolePrivilegeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CreateAdmin)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Admin_RolePrivilege");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
        }
    }
}

