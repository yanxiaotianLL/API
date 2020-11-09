using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_Pay_NotifyMap : EntityTypeConfiguration<T_Gds_Dan_Pay_Notify>
    {
        public T_Gds_Dan_Pay_NotifyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Msg)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Pay_Notify");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.PayState).HasColumnName("PayState");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.CheckDate).HasColumnName("CheckDate");
            this.Property(t => t.Msg).HasColumnName("Msg");
        }
    }
}
