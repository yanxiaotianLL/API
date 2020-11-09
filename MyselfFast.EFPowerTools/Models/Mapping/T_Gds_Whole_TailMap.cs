using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Whole_TailMap : EntityTypeConfiguration<T_Gds_Whole_Tail>
    {
        public T_Gds_Whole_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PlanName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Calculation)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Gds_Whole_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.PlanName).HasColumnName("PlanName");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Fenable).HasColumnName("Fenable");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Costprice).HasColumnName("Costprice");
            this.Property(t => t.Nums).HasColumnName("Nums");
            this.Property(t => t.Sendstate).HasColumnName("Sendstate");
            this.Property(t => t.Mnypay).HasColumnName("Mnypay");
            this.Property(t => t.Fenpay).HasColumnName("Fenpay");
            this.Property(t => t.InterRate).HasColumnName("InterRate");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
            this.Property(t => t.PriceId).HasColumnName("PriceId");
        }
    }
}
