using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_MicrAct_ActiveMap : EntityTypeConfiguration<T_MicrAct_Active>
    {
        public T_MicrAct_ActiveMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Introduction)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.ActiveName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ActiveContent)
                .IsRequired();

            this.Property(t => t.Activetime)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.MicrPic)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.TurnPic)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.AgreementContent)
                .IsRequired();

            this.Property(t => t.ActiveAddress)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ApplyChannel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ActivePrice)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Topic)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_MicrAct_Active");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.Introduction).HasColumnName("Introduction");
            this.Property(t => t.ActiveName).HasColumnName("ActiveName");
            this.Property(t => t.ActiveContent).HasColumnName("ActiveContent");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Foruse).HasColumnName("Foruse");
            this.Property(t => t.Ischarge).HasColumnName("Ischarge");
            this.Property(t => t.Regnum).HasColumnName("Regnum");
            this.Property(t => t.Personnum).HasColumnName("Personnum");
            this.Property(t => t.Val).HasColumnName("Val");
            this.Property(t => t.Regbuttonshow).HasColumnName("Regbuttonshow");
            this.Property(t => t.Activetime).HasColumnName("Activetime");
            this.Property(t => t.Ontop).HasColumnName("Ontop");
            this.Property(t => t.Begindate).HasColumnName("Begindate");
            this.Property(t => t.Enddate).HasColumnName("Enddate");
            this.Property(t => t.MicrPic).HasColumnName("MicrPic");
            this.Property(t => t.TurnPic).HasColumnName("TurnPic");
            this.Property(t => t.Isemp).HasColumnName("Isemp");
            this.Property(t => t.Iswenti).HasColumnName("Iswenti");
            this.Property(t => t.IsChildren).HasColumnName("IsChildren");
            this.Property(t => t.Isxianchang).HasColumnName("Isxianchang");
            this.Property(t => t.Isverify).HasColumnName("Isverify");
            this.Property(t => t.AgreementContent).HasColumnName("AgreementContent");
            this.Property(t => t.ActiveAddress).HasColumnName("ActiveAddress");
            this.Property(t => t.ApplyChannel).HasColumnName("ApplyChannel");
            this.Property(t => t.IsPayOnline).HasColumnName("IsPayOnline");
            this.Property(t => t.ActivePrice).HasColumnName("ActivePrice");
            this.Property(t => t.WelfarePrice).HasColumnName("WelfarePrice");
            this.Property(t => t.WelfareFamilyPrice).HasColumnName("WelfareFamilyPrice");
            this.Property(t => t.NoEmployeePrice).HasColumnName("NoEmployeePrice");
            this.Property(t => t.NoWelfareFamilyPrice).HasColumnName("NoWelfareFamilyPrice");
            this.Property(t => t.NoWelfareChildPrice).HasColumnName("NoWelfareChildPrice");
            this.Property(t => t.WelfareChildPrice).HasColumnName("WelfareChildPrice");
            this.Property(t => t.ActiveType).HasColumnName("ActiveType");
            this.Property(t => t.ActiveFrom).HasColumnName("ActiveFrom");
            this.Property(t => t.IsIndexDisplay).HasColumnName("IsIndexDisplay");
            this.Property(t => t.surplusNum).HasColumnName("surplusNum");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsPromoCode).HasColumnName("IsPromoCode");
            this.Property(t => t.Isshowinlist).HasColumnName("Isshowinlist");
            this.Property(t => t.ReadNum).HasColumnName("ReadNum");
            this.Property(t => t.PointOfPraiseNum).HasColumnName("PointOfPraiseNum");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.Topic).HasColumnName("Topic");
            this.Property(t => t.IsSubActive).HasColumnName("IsSubActive");
            this.Property(t => t.IsCaryChildren).HasColumnName("IsCaryChildren");
            this.Property(t => t.IsShowBillMsg).HasColumnName("IsShowBillMsg");
            this.Property(t => t.DepositMoney).HasColumnName("DepositMoney");
            this.Property(t => t.IsHavingDeposit).HasColumnName("IsHavingDeposit");
            this.Property(t => t.FareCash).HasColumnName("FareCash");
            this.Property(t => t.FameCash).HasColumnName("FameCash");
            this.Property(t => t.FChildCash).HasColumnName("FChildCash");
            this.Property(t => t.NEmpCash).HasColumnName("NEmpCash");
            this.Property(t => t.NFameCash).HasColumnName("NFameCash");
            this.Property(t => t.NFChildCash).HasColumnName("NFChildCash");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsCheckCardAndPwd).HasColumnName("IsCheckCardAndPwd");
            this.Property(t => t.HealthActiveType).HasColumnName("HealthActiveType");
        }
    }
}
