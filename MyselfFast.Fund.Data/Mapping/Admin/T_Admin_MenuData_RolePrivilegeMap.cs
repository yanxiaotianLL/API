//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_MenuData_RolePrivilegeMap : myselfFastEntityTypeConfiguration<T_Admin_MenuData_RolePrivilege>
    {
        public T_Admin_MenuData_RolePrivilegeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Admin_MenuData_RolePrivilege");
            this.Property(t => t.RolePrivilegeID).HasColumnName("RolePrivilegeID");
            this.Property(t => t.MenuDataID).HasColumnName("MenuDataID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}

