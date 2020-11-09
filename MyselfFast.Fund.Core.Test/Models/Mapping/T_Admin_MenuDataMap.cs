using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.Collect.Core.Test.Models.Mapping
{
    public class T_Admin_MenuDataMap : EntityTypeConfiguration<T_Admin_MenuData>
    {
        public T_Admin_MenuDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DataKey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DataValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.UpdateAdmin)
                .HasMaxLength(20);

            this.Property(t => t.Icon)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_Admin_MenuData");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.DataKey).HasColumnName("DataKey");
            this.Property(t => t.DataValue).HasColumnName("DataValue");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CreateAdmin).HasColumnName("CreateAdmin");
            this.Property(t => t.UpdateAdmin).HasColumnName("UpdateAdmin");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.SortValue).HasColumnName("SortValue");
        }
    }
}
