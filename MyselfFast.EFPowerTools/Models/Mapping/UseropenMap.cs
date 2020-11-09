using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class UseropenMap : EntityTypeConfiguration<Useropen>
    {
        public UseropenMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Uid, t.Ghao, t.Gbumen, t.Gjibie, t.Cname, t.Fid, t.Ltd, t.Cardtype, t.Cid, t.Userpass, t.Usergrade, t.Zhekou, t.Qid, t.Answer, t.Sex, t.Tel, t.Phone1, t.Phone2, t.Birth, t.Pborth, t.Mborth, t.Lborth, t.Sborth, t.Province, t.Xian, t.Email, t.Msn, t.Qq, t.Lov, t.Addr, t.Addr1, t.Addr2, t.Postcode, t.Usertype, t.Account, t.Decaccount, t.Regdate, t.Jihuostate, t.Jihuodate, t.Lastdate, t.Thisdate, t.Workstate, t.Memtype, t.Fenall, t.Fencur, t.Fenlock, t.Fenstate, t.Fenlimit, t.Bak, t.Workyear, t.Paypass, t.Ifboys, t.Passover, t.Isusermailed, t.Frunstate, t.Cardman, t.Roleid, t.Hno, t.Haswenti, t.Croleid, t.Verify, t.Verifydate, t.Isfls, t.Attn, t.Attntel, t.Attnemail, t.Isfes, t.Isreg, t.Ip, t.Img, t.Imgbak, t.Hstate, t.Uptime, t.Imgmemo, t.Updatetype, t.Oldfid, t.Oldcid, t.Temp_Jd, t.Open_Id, t.Bindingdate, t.Isbinding, t.Hrcode, t.Leavedate, t.Ruzhidate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Uid)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Ghao)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gbumen)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Gjibie)
                .IsRequired()
                .HasMaxLength(164);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(130);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ltd)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Cardtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Userpass)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Usergrade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Zhekou)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Qid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Answer)
                .IsRequired()
                .HasMaxLength(640);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.Phone1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xian)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Msn)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Qq)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Lov)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Addr)
                .IsRequired()
                .HasMaxLength(1512);

            this.Property(t => t.Addr1)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Addr2)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Usertype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Account)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Decaccount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenall)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fencur)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenlock)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fenstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Workyear)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Paypass)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Ifboys)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Passover)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Frunstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cardman)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Roleid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Croleid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Attn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Attntel)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.Attnemail)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Isreg)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ip)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Img)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Imgbak)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Hstate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Imgmemo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Updatetype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Oldfid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Oldcid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Temp_Jd)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Open_Id)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Bindingdate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Isbinding)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hrcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Useropen");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Uid).HasColumnName("Uid");
            this.Property(t => t.Ghao).HasColumnName("Ghao");
            this.Property(t => t.Gbumen).HasColumnName("Gbumen");
            this.Property(t => t.Gjibie).HasColumnName("Gjibie");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Ltd).HasColumnName("Ltd");
            this.Property(t => t.Cardtype).HasColumnName("Cardtype");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Userpass).HasColumnName("Userpass");
            this.Property(t => t.Usergrade).HasColumnName("Usergrade");
            this.Property(t => t.Zhekou).HasColumnName("Zhekou");
            this.Property(t => t.Qid).HasColumnName("Qid");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Phone1).HasColumnName("Phone1");
            this.Property(t => t.Phone2).HasColumnName("Phone2");
            this.Property(t => t.Birth).HasColumnName("Birth");
            this.Property(t => t.Pborth).HasColumnName("Pborth");
            this.Property(t => t.Mborth).HasColumnName("Mborth");
            this.Property(t => t.Lborth).HasColumnName("Lborth");
            this.Property(t => t.Sborth).HasColumnName("Sborth");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.Xian).HasColumnName("Xian");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Msn).HasColumnName("Msn");
            this.Property(t => t.Qq).HasColumnName("Qq");
            this.Property(t => t.Lov).HasColumnName("Lov");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.Addr1).HasColumnName("Addr1");
            this.Property(t => t.Addr2).HasColumnName("Addr2");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Usertype).HasColumnName("Usertype");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.Decaccount).HasColumnName("Decaccount");
            this.Property(t => t.Regdate).HasColumnName("Regdate");
            this.Property(t => t.Jihuostate).HasColumnName("Jihuostate");
            this.Property(t => t.Jihuodate).HasColumnName("Jihuodate");
            this.Property(t => t.Lastdate).HasColumnName("Lastdate");
            this.Property(t => t.Thisdate).HasColumnName("Thisdate");
            this.Property(t => t.Workstate).HasColumnName("Workstate");
            this.Property(t => t.Memtype).HasColumnName("Memtype");
            this.Property(t => t.Fenall).HasColumnName("Fenall");
            this.Property(t => t.Fencur).HasColumnName("Fencur");
            this.Property(t => t.Fenlock).HasColumnName("Fenlock");
            this.Property(t => t.Fenstate).HasColumnName("Fenstate");
            this.Property(t => t.Fenlimit).HasColumnName("Fenlimit");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.Workyear).HasColumnName("Workyear");
            this.Property(t => t.Paypass).HasColumnName("Paypass");
            this.Property(t => t.Ifboys).HasColumnName("Ifboys");
            this.Property(t => t.Passover).HasColumnName("Passover");
            this.Property(t => t.Isusermailed).HasColumnName("Isusermailed");
            this.Property(t => t.Frunstate).HasColumnName("Frunstate");
            this.Property(t => t.Cardman).HasColumnName("Cardman");
            this.Property(t => t.Roleid).HasColumnName("Roleid");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Haswenti).HasColumnName("Haswenti");
            this.Property(t => t.Croleid).HasColumnName("Croleid");
            this.Property(t => t.Verify).HasColumnName("Verify");
            this.Property(t => t.Verifydate).HasColumnName("Verifydate");
            this.Property(t => t.Isfls).HasColumnName("Isfls");
            this.Property(t => t.Attn).HasColumnName("Attn");
            this.Property(t => t.Attntel).HasColumnName("Attntel");
            this.Property(t => t.Attnemail).HasColumnName("Attnemail");
            this.Property(t => t.Isfes).HasColumnName("Isfes");
            this.Property(t => t.Isreg).HasColumnName("Isreg");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.Img).HasColumnName("Img");
            this.Property(t => t.Imgbak).HasColumnName("Imgbak");
            this.Property(t => t.Hstate).HasColumnName("Hstate");
            this.Property(t => t.Uptime).HasColumnName("Uptime");
            this.Property(t => t.Imgmemo).HasColumnName("Imgmemo");
            this.Property(t => t.Updatetype).HasColumnName("Updatetype");
            this.Property(t => t.Oldfid).HasColumnName("Oldfid");
            this.Property(t => t.Oldcid).HasColumnName("Oldcid");
            this.Property(t => t.Temp_Jd).HasColumnName("Temp_Jd");
            this.Property(t => t.Open_Id).HasColumnName("Open_Id");
            this.Property(t => t.Bindingdate).HasColumnName("Bindingdate");
            this.Property(t => t.Isbinding).HasColumnName("Isbinding");
            this.Property(t => t.Hrcode).HasColumnName("Hrcode");
            this.Property(t => t.Leavedate).HasColumnName("Leavedate");
            this.Property(t => t.Ruzhidate).HasColumnName("Ruzhidate");
        }
    }
}
