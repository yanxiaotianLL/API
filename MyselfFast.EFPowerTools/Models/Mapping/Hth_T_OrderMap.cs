using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hth_T_OrderMap : EntityTypeConfiguration<Hth_T_Order>
    {
        public Hth_T_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DiseaseName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.HisPosition)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SPosition)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuDiseaseName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.OType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProdScheId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.XOrderId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.XOrderItemId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.billno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.ProdPriceName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PackNumber)
                .HasMaxLength(50);

            this.Property(t => t.OcrSign)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Hospital)
                .HasMaxLength(50);

            this.Property(t => t.PositionNew)
                .HasMaxLength(50);

            this.Property(t => t.EntityErrorMsg)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Hth_T_Order");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.CostSort).HasColumnName("CostSort");
            this.Property(t => t.HosId).HasColumnName("HosId");
            this.Property(t => t.SeeDateBin).HasColumnName("SeeDateBin");
            this.Property(t => t.SeeTimeEnd).HasColumnName("SeeTimeEnd");
            this.Property(t => t.DiseaseName).HasColumnName("DiseaseName");
            this.Property(t => t.SelfApplyAmount).HasColumnName("SelfApplyAmount");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
            this.Property(t => t.RealAmount).HasColumnName("RealAmount");
            this.Property(t => t.ForPersonType).HasColumnName("ForPersonType");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.HisPosition).HasColumnName("HisPosition");
            this.Property(t => t.Settlement).HasColumnName("Settlement");
            this.Property(t => t.SPosition).HasColumnName("SPosition");
            this.Property(t => t.AuDiseaseName).HasColumnName("AuDiseaseName");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SelfPay).HasColumnName("SelfPay");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.OType).HasColumnName("OType");
            this.Property(t => t.OTypeId).HasColumnName("OTypeId");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.ProdScheId).HasColumnName("ProdScheId");
            this.Property(t => t.XOrderId).HasColumnName("XOrderId");
            this.Property(t => t.XOrderItemId).HasColumnName("XOrderItemId");
            this.Property(t => t.billno).HasColumnName("billno");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
            this.Property(t => t.TState).HasColumnName("TState");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ProdId).HasColumnName("ProdId");
            this.Property(t => t.ProdPriceId).HasColumnName("ProdPriceId");
            this.Property(t => t.ProdPriceName).HasColumnName("ProdPriceName");
            this.Property(t => t.IsPrint).HasColumnName("IsPrint");
            this.Property(t => t.IsPause).HasColumnName("IsPause");
            this.Property(t => t.IsBeiJing).HasColumnName("IsBeiJing");
            this.Property(t => t.PackNumber).HasColumnName("PackNumber");
            this.Property(t => t.OcrSign).HasColumnName("OcrSign");
            this.Property(t => t.EntityAdminId).HasColumnName("EntityAdminId");
            this.Property(t => t.Sedates).HasColumnName("Sedates");
            this.Property(t => t.hthDeductAmount).HasColumnName("hthDeductAmount");
            this.Property(t => t.IsCallSuccess).HasColumnName("IsCallSuccess");
            this.Property(t => t.Hospital).HasColumnName("Hospital");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.PositionNew).HasColumnName("PositionNew");
            this.Property(t => t.EntityErrorMsg).HasColumnName("EntityErrorMsg");
            this.Property(t => t.DataSource).HasColumnName("DataSource");
        }
    }
}
