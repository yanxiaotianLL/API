using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_RegistrationMap : EntityTypeConfiguration<T_MicrAct_Registration>
    {
        public T_MicrAct_RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input3)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input4)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input5)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input6)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input7)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input8)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input9)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input10)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input11)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input12)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input13)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input14)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input15)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input16)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input17)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input18)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input19)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Input20)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gdsnum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayRemark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillTitle)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillSendAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillReceiveTel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ConfirmOrderOperator)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PromoCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillContent)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JoinPerson)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillReceiver)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BenefitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PiaoNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Registration");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActiveID).HasColumnName("ActiveID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.Input1).HasColumnName("Input1");
            this.Property(t => t.Input2).HasColumnName("Input2");
            this.Property(t => t.Input3).HasColumnName("Input3");
            this.Property(t => t.Input4).HasColumnName("Input4");
            this.Property(t => t.Input5).HasColumnName("Input5");
            this.Property(t => t.Input6).HasColumnName("Input6");
            this.Property(t => t.Input7).HasColumnName("Input7");
            this.Property(t => t.Input8).HasColumnName("Input8");
            this.Property(t => t.Input9).HasColumnName("Input9");
            this.Property(t => t.Input10).HasColumnName("Input10");
            this.Property(t => t.Input11).HasColumnName("Input11");
            this.Property(t => t.Input12).HasColumnName("Input12");
            this.Property(t => t.Input13).HasColumnName("Input13");
            this.Property(t => t.Input14).HasColumnName("Input14");
            this.Property(t => t.Input15).HasColumnName("Input15");
            this.Property(t => t.Input16).HasColumnName("Input16");
            this.Property(t => t.Input17).HasColumnName("Input17");
            this.Property(t => t.Input18).HasColumnName("Input18");
            this.Property(t => t.Input19).HasColumnName("Input19");
            this.Property(t => t.Input20).HasColumnName("Input20");
            this.Property(t => t.Gdsnum).HasColumnName("Gdsnum");
            this.Property(t => t.Paystatus).HasColumnName("Paystatus");
            this.Property(t => t.Fenday).HasColumnName("Fenday");
            this.Property(t => t.Payway).HasColumnName("Payway");
            this.Property(t => t.Personnum).HasColumnName("Personnum");
            this.Property(t => t.Totalpay).HasColumnName("Totalpay");
            this.Property(t => t.Selfpay).HasColumnName("Selfpay");
            this.Property(t => t.OrderTime).HasColumnName("OrderTime");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.PayRemark).HasColumnName("PayRemark");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsRequireBill).HasColumnName("IsRequireBill");
            this.Property(t => t.BillTitle).HasColumnName("BillTitle");
            this.Property(t => t.GetBillWay).HasColumnName("GetBillWay");
            this.Property(t => t.BillSendAddress).HasColumnName("BillSendAddress");
            this.Property(t => t.BillReceiveTel).HasColumnName("BillReceiveTel");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.ConfirmOrderStatus).HasColumnName("ConfirmOrderStatus");
            this.Property(t => t.ConfirmOrderOperator).HasColumnName("ConfirmOrderOperator");
            this.Property(t => t.ConfirmOrderTime).HasColumnName("ConfirmOrderTime");
            this.Property(t => t.PromoCode).HasColumnName("PromoCode");
            this.Property(t => t.BillContent).HasColumnName("BillContent");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.ApplyStatus).HasColumnName("ApplyStatus");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.ParentActiveID).HasColumnName("ParentActiveID");
            this.Property(t => t.JoinPerson).HasColumnName("JoinPerson");
            this.Property(t => t.AbDateID).HasColumnName("AbDateID");
            this.Property(t => t.BillReceiver).HasColumnName("BillReceiver");
            this.Property(t => t.BenefitType).HasColumnName("BenefitType");
            this.Property(t => t.BenefitName).HasColumnName("BenefitName");
            this.Property(t => t.SignUpType).HasColumnName("SignUpType");
            this.Property(t => t.CardID).HasColumnName("CardID");
            this.Property(t => t.ActiveFrom).HasColumnName("ActiveFrom");
            this.Property(t => t.PiaoType).HasColumnName("PiaoType");
            this.Property(t => t.PiaoNumber).HasColumnName("PiaoNumber");
        }
    }
}
