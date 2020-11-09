using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_Order_BakMap : EntityTypeConfiguration<T_Exm_Order_Bak>
    {
        public T_Exm_Order_BakMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.TguId, t.Fesid, t.Pay, t.SubTime, t.Status, t.StatusName, t.OrderId, t.PayType, t.PayTime, t.PayMemo, t.IsPiao, t.PrintDate, t.PiaoTitle, t.PrintState, t.SendNo, t.SendDate, t.SendType, t.ShouaddrId, t.Shouaddr, t.ShouaddrSimple, t.ShouaddrTag, t.PiaoContent, t.ShouMan, t.ShouTel, t.ShouPost, t.IsMailed, t.BackDate, t.DackMemo, t.TuiDate, t.TuiStatus, t.Fid, t.Id_order, t.IsBag, t.CheckType, t.IsUpgrade, t.HasRealCard, t.PSID, t.POrderNo, t.HasSubs, t.IsDelete, t.FinDate, t.Alipayno, t.Adminname, t.Adminid, t.Lastdate, t.KdCompany, t.CostType, t.PiaoFname, t.PiaoNumber, t.PiaoType });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Pay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderId)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PayType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayMemo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PiaoTitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PrintState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SendNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SendType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShouaddrId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.IsMailed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DackMemo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TuiStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Id_order)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PSID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.POrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Alipayno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Adminname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Adminid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KdCompany)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CostType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PiaoFname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PiaoType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Exm_Order_Bak");
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
        }
    }
}
