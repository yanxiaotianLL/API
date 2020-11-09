using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_MicrAct_RegistrationMap : EntityTypeConfiguration<V_MicrAct_Registration>
    {
        public V_MicrAct_RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Hno, t.Cname, t.Ename, t.Usedname, t.Gno, t.CardId, t.Mobile });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Username)
                .HasMaxLength(50);

            this.Property(t => t.Input1)
                .HasMaxLength(50);

            this.Property(t => t.Input2)
                .HasMaxLength(50);

            this.Property(t => t.Input3)
                .HasMaxLength(50);

            this.Property(t => t.Input4)
                .HasMaxLength(50);

            this.Property(t => t.Input5)
                .HasMaxLength(50);

            this.Property(t => t.Input6)
                .HasMaxLength(50);

            this.Property(t => t.Input7)
                .HasMaxLength(50);

            this.Property(t => t.Input8)
                .HasMaxLength(50);

            this.Property(t => t.Input9)
                .HasMaxLength(50);

            this.Property(t => t.Input10)
                .HasMaxLength(50);

            this.Property(t => t.Input11)
                .HasMaxLength(50);

            this.Property(t => t.Input12)
                .HasMaxLength(50);

            this.Property(t => t.Input13)
                .HasMaxLength(50);

            this.Property(t => t.Input14)
                .HasMaxLength(50);

            this.Property(t => t.Input15)
                .HasMaxLength(50);

            this.Property(t => t.Input16)
                .HasMaxLength(50);

            this.Property(t => t.Input17)
                .HasMaxLength(50);

            this.Property(t => t.Input18)
                .HasMaxLength(50);

            this.Property(t => t.Input19)
                .HasMaxLength(50);

            this.Property(t => t.Input20)
                .HasMaxLength(50);

            this.Property(t => t.Gdsnum)
                .HasMaxLength(50);

            this.Property(t => t.PayRemark)
                .HasMaxLength(500);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            this.Property(t => t.BillTitle)
                .HasMaxLength(200);

            this.Property(t => t.BillSendAddress)
                .HasMaxLength(200);

            this.Property(t => t.BillReceiveTel)
                .HasMaxLength(20);

            this.Property(t => t.ConfirmOrderOperator)
                .HasMaxLength(50);

            this.Property(t => t.PromoCode)
                .HasMaxLength(50);

            this.Property(t => t.BillContent)
                .HasMaxLength(500);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            this.Property(t => t.JoinPerson)
                .HasMaxLength(200);

            this.Property(t => t.Benefitname)
                .HasMaxLength(50);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Usedname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.CardId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_MicrAct_Registration");
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
            this.Property(t => t.Benefittype).HasColumnName("Benefittype");
            this.Property(t => t.Benefitname).HasColumnName("Benefitname");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
