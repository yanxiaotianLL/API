using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_Payed_NotifyMap : EntityTypeConfiguration<T_Gds_Dan_Payed_Notify>
    {
        public T_Gds_Dan_Payed_NotifyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Payed_Notify");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
        }
    }
}
