using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Pkg_ItemMap : EntityTypeConfiguration<T_Exm_Pkg_Item>
    {
        public T_Exm_Pkg_ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_Exm_Pkg_Item");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PriceMarket).HasColumnName("PriceMarket");
            this.Property(t => t.PriceSales).HasColumnName("PriceSales");
            this.Property(t => t.PriceEmployee).HasColumnName("PriceEmployee");
            this.Property(t => t.IsCurrentUse).HasColumnName("IsCurrentUse");
            this.Property(t => t.ItemType).HasColumnName("ItemType");
        }
    }
}
