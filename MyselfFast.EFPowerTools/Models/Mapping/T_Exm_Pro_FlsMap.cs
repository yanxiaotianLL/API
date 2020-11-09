using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Pro_FlsMap : EntityTypeConfiguration<T_Exm_Pro_Fls>
    {
        public T_Exm_Pro_FlsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ProjectPrompt)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("T_Exm_Pro_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ProId).HasColumnName("ProId");
            this.Property(t => t.PriceMarket).HasColumnName("PriceMarket");
            this.Property(t => t.PriceSales).HasColumnName("PriceSales");
            this.Property(t => t.PriceEmployee).HasColumnName("PriceEmployee");
            this.Property(t => t.IsCurrentUse).HasColumnName("IsCurrentUse");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.PricePromoCode).HasColumnName("PricePromoCode");
            this.Property(t => t.IsUsePromoCode).HasColumnName("IsUsePromoCode");
            this.Property(t => t.PriceRakeBack).HasColumnName("PriceRakeBack");
            this.Property(t => t.ProjectPrompt).HasColumnName("ProjectPrompt");
        }
    }
}
