using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_OrderAndWrap_InfoMap : EntityTypeConfiguration<Hth_OrderAndWrap_Info>
    {
        public Hth_OrderAndWrap_InfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderWrapCode, t.ID, t.CreateTime, t.OrderNo, t.SeeDateBin, t.ForPersonType, t.OrderState, t.UpdateTime, t.Fesid, t.RealAmount });

            // Properties
            this.Property(t => t.OrderWrapCode)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ForPersonType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Hth_OrderAndWrap_Info");
            this.Property(t => t.OrderWrapCode).HasColumnName("OrderWrapCode");
            this.Property(t => t.OrderWrapState).HasColumnName("OrderWrapState");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.SeeDateBin).HasColumnName("SeeDateBin");
            this.Property(t => t.ForPersonType).HasColumnName("ForPersonType");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.OrderIsDelete).HasColumnName("OrderIsDelete");
            this.Property(t => t.WrapIsDelete).HasColumnName("WrapIsDelete");
            this.Property(t => t.WrapCreateTime).HasColumnName("WrapCreateTime");
            this.Property(t => t.RealAmount).HasColumnName("RealAmount");
        }
    }
}
