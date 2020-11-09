//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Admin;

namespace myselfFast.Fund.Data.Mapping.Admin
{
    public class T_Admin_RoleDataMap : myselfFastEntityTypeConfiguration<T_Admin_RoleData>
    {
        public T_Admin_RoleDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DataValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DataKey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.Icon)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Admin_RoleData");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DataValue).HasColumnName("DataValue");
            this.Property(t => t.DataKey).HasColumnName("DataKey");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
        }
    }
}

