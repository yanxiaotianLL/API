using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_HK_OrderMap : EntityTypeConfiguration<T_HK_Order>
    {
        public T_HK_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Uniqueno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BussinessName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AddrStr)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AddrStrTag)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.TradeNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SellerAccount)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BuyerAccount)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Updater)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Statename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoTitle)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PiaoUse)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Kno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.KName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TradeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pone)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Letterpeople)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backcause)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cancelcause)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IsBackYajin)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BKno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BKName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShouMan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Adress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Alipayno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Backno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Receivename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UserAlipayNo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserTel)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("T_HK_Order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uniqueno).HasColumnName("Uniqueno");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.BussinessId).HasColumnName("BussinessId");
            this.Property(t => t.BussinessName).HasColumnName("BussinessName");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.OrderTime).HasColumnName("OrderTime");
            this.Property(t => t.OrderAmount).HasColumnName("OrderAmount");
            this.Property(t => t.AddrId).HasColumnName("AddrId");
            this.Property(t => t.AddrStr).HasColumnName("AddrStr");
            this.Property(t => t.AddrStrTag).HasColumnName("AddrStrTag");
            this.Property(t => t.Transtype).HasColumnName("Transtype");
            this.Property(t => t.Committime).HasColumnName("Committime");
            this.Property(t => t.TradeNo).HasColumnName("TradeNo");
            this.Property(t => t.TradeMehtod).HasColumnName("TradeMehtod");
            this.Property(t => t.TradeTime).HasColumnName("TradeTime");
            this.Property(t => t.SellerAccount).HasColumnName("SellerAccount");
            this.Property(t => t.BuyerAccount).HasColumnName("BuyerAccount");
            this.Property(t => t.Updater).HasColumnName("Updater");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Statename).HasColumnName("Statename");
            this.Property(t => t.PiaoState).HasColumnName("PiaoState");
            this.Property(t => t.PiaoTitle).HasColumnName("PiaoTitle");
            this.Property(t => t.PiaoUse).HasColumnName("PiaoUse");
            this.Property(t => t.PrintState).HasColumnName("PrintState");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
            this.Property(t => t.Kno).HasColumnName("Kno");
            this.Property(t => t.KName).HasColumnName("KName");
            this.Property(t => t.TradeName).HasColumnName("TradeName");
            this.Property(t => t.Pone).HasColumnName("Pone");
            this.Property(t => t.Letterpeople).HasColumnName("Letterpeople");
            this.Property(t => t.Backcause).HasColumnName("Backcause");
            this.Property(t => t.Cancelcause).HasColumnName("Cancelcause");
            this.Property(t => t.EndLendTime).HasColumnName("EndLendTime");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.IsBackYajin).HasColumnName("IsBackYajin");
            this.Property(t => t.BKno).HasColumnName("BKno");
            this.Property(t => t.BKName).HasColumnName("BKName");
            this.Property(t => t.OrderDeposit).HasColumnName("OrderDeposit");
            this.Property(t => t.OneTime).HasColumnName("OneTime");
            this.Property(t => t.TwoTime).HasColumnName("TwoTime");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.ShouMan).HasColumnName("ShouMan");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Adress).HasColumnName("Adress");
            this.Property(t => t.Alipayno).HasColumnName("Alipayno");
            this.Property(t => t.Backno).HasColumnName("Backno");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Expressbacktime).HasColumnName("Expressbacktime");
            this.Property(t => t.Threetime).HasColumnName("Threetime");
            this.Property(t => t.ReceiveMehtod).HasColumnName("ReceiveMehtod");
            this.Property(t => t.Receivename).HasColumnName("Receivename");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
            this.Property(t => t.IsApplyMoney).HasColumnName("IsApplyMoney");
            this.Property(t => t.UserAlipayNo).HasColumnName("UserAlipayNo");
            this.Property(t => t.UserTel).HasColumnName("UserTel");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
        }
    }
}
