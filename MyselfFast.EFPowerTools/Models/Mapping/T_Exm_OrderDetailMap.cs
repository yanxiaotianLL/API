using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_OrderDetailMap : EntityTypeConfiguration<T_Exm_OrderDetail>
    {
        public T_Exm_OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CardRule)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PackageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardRule_Old)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardNo_Old)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("T_Exm_OrderDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sid).HasColumnName("Sid");
            this.Property(t => t.ParentGuid).HasColumnName("ParentGuid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CardRule).HasColumnName("CardRule");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.PackageName).HasColumnName("PackageName");
            this.Property(t => t.BuyNum).HasColumnName("BuyNum");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
            this.Property(t => t.ProjectId_Old).HasColumnName("ProjectId_Old");
            this.Property(t => t.PackageId_Old).HasColumnName("PackageId_Old");
            this.Property(t => t.CardRule_Old).HasColumnName("CardRule_Old");
            this.Property(t => t.CardNo_Old).HasColumnName("CardNo_Old");
            this.Property(t => t.PSID).HasColumnName("PSID");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.TExmPkgItemId).HasColumnName("TExmPkgItemId");
            this.Property(t => t.TExmPromId).HasColumnName("TExmPromId");
            this.Property(t => t.PriceSales).HasColumnName("PriceSales");
            this.Property(t => t.IsUsePromoCode).HasColumnName("IsUsePromoCode");
            this.Property(t => t.PriceRakeBack).HasColumnName("PriceRakeBack");
            this.Property(t => t.TtlSales).HasColumnName("TtlSales");
            this.Property(t => t.TtlRakeBack).HasColumnName("TtlRakeBack");
        }
    }
}
