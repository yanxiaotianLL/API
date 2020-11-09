using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Admin_RoleData_RolePrivilegeMap : EntityTypeConfiguration<T_Admin_RoleData_RolePrivilege>
    {
        public T_Admin_RoleData_RolePrivilegeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Admin_RoleData_RolePrivilege");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleDataID).HasColumnName("RoleDataID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
        }
    }
}
