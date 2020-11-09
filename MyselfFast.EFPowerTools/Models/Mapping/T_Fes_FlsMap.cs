using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_FlsMap : EntityTypeConfiguration<T_Fes_Fls>
    {
        public T_Fes_FlsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ename)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Linkman)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Prov)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Logo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Logoben)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Logobenleft)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Benbg)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Logo01)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Logo02)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Filelink)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Guanggaolink)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fesfilelink)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Yname1)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Ytcode1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ytel1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ymobile1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yemail1)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Yname2)
                .HasMaxLength(150);

            this.Property(t => t.Ytcode2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ytel2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ymobile2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Yemail2)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Pagestyle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zbaoxiao)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ShortName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Script).HasColumnName("Script");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Linkman).HasColumnName("Linkman");
            this.Property(t => t.Tmax).HasColumnName("Tmax");
            this.Property(t => t.Htlimit).HasColumnName("Htlimit");
            this.Property(t => t.Stype).HasColumnName("Stype");
            this.Property(t => t.Prov).HasColumnName("Prov");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Logo).HasColumnName("Logo");
            this.Property(t => t.Logoben).HasColumnName("Logoben");
            this.Property(t => t.Logobenleft).HasColumnName("Logobenleft");
            this.Property(t => t.Benbg).HasColumnName("Benbg");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Tempstate).HasColumnName("Tempstate");
            this.Property(t => t.Lmttype).HasColumnName("Lmttype");
            this.Property(t => t.Needchk).HasColumnName("Needchk");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Tag).HasColumnName("Tag");
            this.Property(t => t.Logo01).HasColumnName("Logo01");
            this.Property(t => t.Logo02).HasColumnName("Logo02");
            this.Property(t => t.Filelink).HasColumnName("Filelink");
            this.Property(t => t.Danday).HasColumnName("Danday");
            this.Property(t => t.Sl).HasColumnName("Sl");
            this.Property(t => t.Ptf).HasColumnName("Ptf");
            this.Property(t => t.Ismailed).HasColumnName("Ismailed");
            this.Property(t => t.Needdan).HasColumnName("Needdan");
            this.Property(t => t.Guanggaolink).HasColumnName("Guanggaolink");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Fesfilelink).HasColumnName("Fesfilelink");
            this.Property(t => t.Isfankuiserv).HasColumnName("Isfankuiserv");
            this.Property(t => t.Yname1).HasColumnName("Yname1");
            this.Property(t => t.Ytcode1).HasColumnName("Ytcode1");
            this.Property(t => t.Ytel1).HasColumnName("Ytel1");
            this.Property(t => t.Ymobile1).HasColumnName("Ymobile1");
            this.Property(t => t.Yemail1).HasColumnName("Yemail1");
            this.Property(t => t.Yname2).HasColumnName("Yname2");
            this.Property(t => t.Ytcode2).HasColumnName("Ytcode2");
            this.Property(t => t.Ytel2).HasColumnName("Ytel2");
            this.Property(t => t.Ymobile2).HasColumnName("Ymobile2");
            this.Property(t => t.Yemail2).HasColumnName("Yemail2");
            this.Property(t => t.Isloginbenefit).HasColumnName("Isloginbenefit");
            this.Property(t => t.Usecash).HasColumnName("Usecash");
            this.Property(t => t.Isbuyding).HasColumnName("Isbuyding");
            this.Property(t => t.Accounttype).HasColumnName("Accounttype");
            this.Property(t => t.Istjserv).HasColumnName("Istjserv");
            this.Property(t => t.Pagestyle).HasColumnName("Pagestyle");
            this.Property(t => t.Isdelete).HasColumnName("Isdelete");
            this.Property(t => t.IsMedical).HasColumnName("IsMedical");
            this.Property(t => t.Pbaoxiao).HasColumnName("Pbaoxiao");
            this.Property(t => t.Zbaoxiao).HasColumnName("Zbaoxiao");
            this.Property(t => t.Provid).HasColumnName("Provid");
            this.Property(t => t.Xianid).HasColumnName("Xianid");
            this.Property(t => t.FenStyle).HasColumnName("FenStyle");
            this.Property(t => t.LeaveStyle).HasColumnName("LeaveStyle");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.UpdateId).HasColumnName("UpdateId");
            this.Property(t => t.IsServForFl).HasColumnName("IsServForFl");
            this.Property(t => t.IsServForOnsite).HasColumnName("IsServForOnsite");
            this.Property(t => t.IsServForCheck).HasColumnName("IsServForCheck");
            this.Property(t => t.IsServForEntry).HasColumnName("IsServForEntry");
        }
    }
}
