using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_UserMap : EntityTypeConfiguration<T_Fes_User>
    {
        public T_Fes_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Sname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.PayPass)
                .IsRequired()
                .HasMaxLength(64);

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

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.EduName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.custName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.busiCustName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.conName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.acceName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Open_Id)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.UnionId)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("T_Fes_User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Sid).HasColumnName("Sid");
            this.Property(t => t.Sname).HasColumnName("Sname");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.PayPass).HasColumnName("PayPass");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Borth).HasColumnName("Borth");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Edustate).HasColumnName("Edustate");
            this.Property(t => t.EduName).HasColumnName("EduName");
            this.Property(t => t.Mrstate).HasColumnName("Mrstate");
            this.Property(t => t.Wentifuli).HasColumnName("Wentifuli");
            this.Property(t => t.Verify).HasColumnName("Verify");
            this.Property(t => t.SafeVerify).HasColumnName("SafeVerify");
            this.Property(t => t.Isdeleted).HasColumnName("Isdeleted");
            this.Property(t => t.Createtime).HasColumnName("Createtime");
            this.Property(t => t.custId).HasColumnName("custId");
            this.Property(t => t.custName).HasColumnName("custName");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
            this.Property(t => t.busiCustName).HasColumnName("busiCustName");
            this.Property(t => t.conId).HasColumnName("conId");
            this.Property(t => t.conName).HasColumnName("conName");
            this.Property(t => t.acceId).HasColumnName("acceId");
            this.Property(t => t.acceName).HasColumnName("acceName");
            this.Property(t => t.Workstate).HasColumnName("Workstate");
            this.Property(t => t.ExtWorkstate).HasColumnName("ExtWorkstate");
            this.Property(t => t.InsType).HasColumnName("InsType");
            this.Property(t => t.Open_Id).HasColumnName("Open_Id");
            this.Property(t => t.Hmuserid).HasColumnName("Hmuserid");
            this.Property(t => t.UpdateId).HasColumnName("UpdateId");
            this.Property(t => t.empStatus).HasColumnName("empStatus");
            this.Property(t => t.IsBind).HasColumnName("IsBind");
            this.Property(t => t.IsBindTime).HasColumnName("IsBindTime");
            this.Property(t => t.IsNewSysSyn).HasColumnName("IsNewSysSyn");
            this.Property(t => t.IsNewSysSynTime).HasColumnName("IsNewSysSynTime");
            this.Property(t => t.IsRealCheck).HasColumnName("IsRealCheck");
            this.Property(t => t.IsRealCheckTime).HasColumnName("IsRealCheckTime");
            this.Property(t => t.UnionId).HasColumnName("UnionId");
            this.Property(t => t.WechatBindTime).HasColumnName("WechatBindTime");
        }
    }
}
