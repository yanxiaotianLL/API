using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_Admin_RoleMap : EntityTypeConfiguration<T_Admin_Role>
    {
        public T_Admin_RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RoleDescription)
                .HasMaxLength(20);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.UpdateAdmin)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_Admin_Role");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.RoleDescription).HasColumnName("RoleDescription");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.UpdateAdmin).HasColumnName("UpdateAdmin");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
        }
    }
}
