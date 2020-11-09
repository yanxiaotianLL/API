using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Dan_TuiMap : EntityTypeConfiguration<T_Gds_Dan_Tui>
    {
        public T_Gds_Dan_TuiMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Gds_Dan_Tui");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Mny).HasColumnName("Mny");
            this.Property(t => t.GenDate).HasColumnName("GenDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Planid).HasColumnName("Planid");
        }
    }
}
