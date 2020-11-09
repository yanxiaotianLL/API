using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_TempHistoryOrderMap : EntityTypeConfiguration<Hth_T_TempHistoryOrder>
    {
        public Hth_T_TempHistoryOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hth_T_TempHistoryOrder");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.OrderWrapID).HasColumnName("OrderWrapID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.OrderStateOld).HasColumnName("OrderStateOld");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.OrderWrapState).HasColumnName("OrderWrapState");
        }
    }
}
