using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_OrderItemMap : EntityTypeConfiguration<T_HK_OrderItem>
    {
        public T_HK_OrderItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_HK_OrderItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
        }
    }
}
