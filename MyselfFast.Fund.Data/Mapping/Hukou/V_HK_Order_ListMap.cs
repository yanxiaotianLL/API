//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Hukou;

namespace myselfFast.Fund.Data.Mapping.Hukou
{
    public class V_HK_Order_ListMap : myselfFastEntityTypeConfiguration<V_HK_Order_List>
    {
        public V_HK_Order_ListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sumnum, t.dianziOrder, t.kuaidiOrder, t.IsGuihuanMenu, t.IsEditKuaidiMenu,t.IsGuanliMenu,t.IsJyQianchu, t.Id, t.Uniqueno, t.Fesid, t.BussinessId, t.BussinessName, t.OrderNo, t.OrderTime, t.OrderAmount, t.AddrId, t.AddrStr, t.AddrStrTag, t.Transtype, t.Committime, t.TradeNo, t.TradeMehtod, t.TradeTime, t.SellerAccount, t.BuyerAccount, t.Updater, t.UpdateTime, t.State, t.Statename, t.PiaoState, t.PiaoTitle, t.PiaoUse, t.PrintState, t.PrintDate, t.Kno, t.KName, t.TradeName, t.Pone, t.Letterpeople, t.Backcause, t.Cancelcause, t.EndLendTime, t.Frequency, t.IsBackYajin, t.BKno, t.BKName, t.OrderDeposit, t.OneTime, t.TwoTime, t.BackTime, t.ShouMan, t.Postcode, t.Tel, t.Adress, t.Alipayno, t.Backno, t.Email, t.Expressbacktime, t.Threetime, t.ReceiveMehtod, t.Receivename, t.PiaoNumber, t.IsApplyMoney, t.UserAlipayNo, t.UserTel, t.ApplyTime, t.OrderFrom, t.TradeStatus, t.BackMoneyPic, t.BKDOperId, t.BYJOperId, t.OrderRelevance, t.ProvinceName, t.CityName, t.IsSendEmail });

            // Properties
            this.Property(t => t.sumnum)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.dianziOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.kuaidiOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsGuihuanMenu)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IsEditKuaidiMenu)
                .IsRequired()
                .HasMaxLength(1);
            this.Property(t => t.IsGuanliMenu)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IsJyQianchu)
                .IsRequired()
                .HasMaxLength(1);
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uniqueno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BussinessId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BussinessName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddrId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddrStr)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AddrStrTag)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Transtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TradeNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TradeMehtod)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SellerAccount)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BuyerAccount)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Updater)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Statename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Frequency)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsBackYajin)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BKno)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BKName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderDeposit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.ReceiveMehtod)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Receivename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IsApplyMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserAlipayNo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserTel)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.OrderFrom)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TradeStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackMoneyPic)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BKDOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BYJOperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderRelevance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProvinceName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CityName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsSendEmail)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uCname)
                .HasMaxLength(4000);

            this.Property(t => t.uMobile)
                .HasMaxLength(4000);

            this.Property(t => t.uEmail)
                .HasMaxLength(4000);

            this.Property(t => t.uCardId)
                .HasMaxLength(4000);

            this.Property(t => t.Fname)
                .HasMaxLength(200);

            this.Property(t => t.Otherdesc)
                .HasMaxLength(100);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            this.Property(t => t.OrderType)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceTitle)
                .HasMaxLength(200);

            this.Property(t => t.InvoiceName)
                .HasMaxLength(50);

            this.Property(t => t.TaxpayerNum)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("V_HK_Order_List");
            this.Property(t => t.sumnum).HasColumnName("sumnum");
            this.Property(t => t.dianziOrder).HasColumnName("dianziOrder");
            this.Property(t => t.kuaidiOrder).HasColumnName("kuaidiOrder");
            this.Property(t => t.IsGuihuanMenu).HasColumnName("IsGuihuanMenu");
            this.Property(t => t.IsEditKuaidiMenu).HasColumnName("IsEditKuaidiMenu");
            this.Property(t => t.IsGuanliMenu).HasColumnName("IsGuanliMenu");
            this.Property(t => t.IsJyQianchu).HasColumnName("IsJyQianchu");

            this.Property(t => t.NumDetail).HasColumnName("NumDetail");
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
            this.Property(t => t.OrderFrom).HasColumnName("OrderFrom");
            this.Property(t => t.TradeStatus).HasColumnName("TradeStatus");
            this.Property(t => t.BackMoneyPic).HasColumnName("BackMoneyPic");
            this.Property(t => t.BKDOperId).HasColumnName("BKDOperId");
            this.Property(t => t.BYJOperId).HasColumnName("BYJOperId");
            this.Property(t => t.OrderRelevance).HasColumnName("OrderRelevance");
            this.Property(t => t.ProvinceName).HasColumnName("ProvinceName");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.IsSendEmail).HasColumnName("IsSendEmail");
            this.Property(t => t.uCname).HasColumnName("uCname");
            this.Property(t => t.uMobile).HasColumnName("uMobile");
            this.Property(t => t.uEmail).HasColumnName("uEmail");
            this.Property(t => t.uCardId).HasColumnName("uCardId");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Copydoc).HasColumnName("Copydoc");
            this.Property(t => t.Originaldoc).HasColumnName("Originaldoc");
            this.Property(t => t.Firstpage).HasColumnName("Firstpage");
            this.Property(t => t.Firstcopy).HasColumnName("Firstcopy");
            this.Property(t => t.Otherdesc).HasColumnName("Otherdesc");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OrderType).HasColumnName("OrderType");
            this.Property(t => t.Sid).HasColumnName("Sid");
            this.Property(t => t.InvoiceTitleType).HasColumnName("InvoiceTitleType");
            this.Property(t => t.InvoiceTitle).HasColumnName("InvoiceTitle");
            this.Property(t => t.InvoiceName).HasColumnName("InvoiceName");
            this.Property(t => t.TaxpayerNum).HasColumnName("TaxpayerNum");
            this.Property(t => t.InvoiceType).HasColumnName("InvoiceType");
            this.Property(t => t.InvoicePaper).HasColumnName("InvoicePaper");
        }
    }
}
