using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OrderWrapItemMap : EntityTypeConfiguration<Hth_T_OrderWrapItem>
    {
        public Hth_T_OrderWrapItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hth_T_OrderWrapItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderWrapID).HasColumnName("OrderWrapID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsFen).HasColumnName("IsFen");
        }
    }
}
