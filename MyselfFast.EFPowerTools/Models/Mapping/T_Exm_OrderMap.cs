using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_OrderMap : EntityTypeConfiguration<T_Exm_Order>
    {
        public T_Exm_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderId)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PayMemo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PiaoTitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SendNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Shouaddr)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShouaddrSimple)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShouaddrTag)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.PiaoContent)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ShouMan)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShouTel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShouPost)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DackMemo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.POrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Alipayno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Adminname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KdCompany)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoFname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DataFrom)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Exm_Order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TguId).HasColumnName("TguId");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Pay).HasColumnName("Pay");
            this.Property(t => t.SubTime).HasColumnName("SubTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.PayType).HasColumnName("PayType");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.PayMemo).HasColumnName("PayMemo");
            this.Property(t => t.IsPiao).HasColumnName("IsPiao");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
            this.Property(t => t.PiaoTitle).HasColumnName("PiaoTitle");
            this.Property(t => t.PrintState).HasColumnName("PrintState");
            this.Property(t => t.SendNo).HasColumnName("SendNo");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.SendType).HasColumnName("SendType");
            this.Property(t => t.ShouaddrId).HasColumnName("ShouaddrId");
            this.Property(t => t.Shouaddr).HasColumnName("Shouaddr");
            this.Property(t => t.ShouaddrSimple).HasColumnName("ShouaddrSimple");
            this.Property(t => t.ShouaddrTag).HasColumnName("ShouaddrTag");
            this.Property(t => t.PiaoContent).HasColumnName("PiaoContent");
            this.Property(t => t.ShouMan).HasColumnName("ShouMan");
            this.Property(t => t.ShouTel).HasColumnName("ShouTel");
            this.Property(t => t.ShouPost).HasColumnName("ShouPost");
            this.Property(t => t.IsMailed).HasColumnName("IsMailed");
            this.Property(t => t.BackDate).HasColumnName("BackDate");
            this.Property(t => t.DackMemo).HasColumnName("DackMemo");
            this.Property(t => t.TuiDate).HasColumnName("TuiDate");
            this.Property(t => t.TuiStatus).HasColumnName("TuiStatus");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Id_order).HasColumnName("Id_order");
            this.Property(t => t.IsBag).HasColumnName("IsBag");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
            this.Property(t => t.IsUpgrade).HasColumnName("IsUpgrade");
            this.Property(t => t.HasRealCard).HasColumnName("HasRealCard");
            this.Property(t => t.PSID).HasColumnName("PSID");
            this.Property(t => t.POrderNo).HasColumnName("POrderNo");
            this.Property(t => t.HasSubs).HasColumnName("HasSubs");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.FinDate).HasColumnName("FinDate");
            this.Property(t => t.Alipayno).HasColumnName("Alipayno");
            this.Property(t => t.Adminname).HasColumnName("Adminname");
            this.Property(t => t.Adminid).HasColumnName("Adminid");
            this.Property(t => t.Lastdate).HasColumnName("Lastdate");
            this.Property(t => t.KdCompany).HasColumnName("KdCompany");
            this.Property(t => t.CostType).HasColumnName("CostType");
            this.Property(t => t.PiaoFname).HasColumnName("PiaoFname");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
            this.Property(t => t.PiaoType).HasColumnName("PiaoType");
            this.Property(t => t.IsUsePromoCode).HasColumnName("IsUsePromoCode");
            this.Property(t => t.TtlSales).HasColumnName("TtlSales");
            this.Property(t => t.TtlRakeBack).HasColumnName("TtlRakeBack");
            this.Property(t => t.DataFrom).HasColumnName("DataFrom");
            this.Property(t => t.PromoCode).HasColumnName("PromoCode");
        }
    }
}
