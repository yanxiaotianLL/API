using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Imp_NewUser_TailMap : EntityTypeConfiguration<T_Imp_NewUser_Tail>
    {
        public T_Imp_NewUser_TailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Yewubu)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Yewuyuanname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Suozaigongsi)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.busiCustNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.conNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UseName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Gno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Cardid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Provname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Xianname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Suozaibumen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gangweijibie)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Zuoji)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Lianxidizhi)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PassWord)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.ErrorMsg)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Imp_NewUser_Tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Pc).HasColumnName("Pc");
            this.Property(t => t.Yewubu).HasColumnName("Yewubu");
            this.Property(t => t.Yewuyuanname).HasColumnName("Yewuyuanname");
            this.Property(t => t.Suozaigongsi).HasColumnName("Suozaigongsi");
            this.Property(t => t.busiCustNo).HasColumnName("busiCustNo");
            this.Property(t => t.conNo).HasColumnName("conNo");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.UseName).HasColumnName("UseName");
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Cardid).HasColumnName("Cardid");
            this.Property(t => t.Borth).HasColumnName("Borth");
            this.Property(t => t.Provid).HasColumnName("Provid");
            this.Property(t => t.Provname).HasColumnName("Provname");
            this.Property(t => t.Xianid).HasColumnName("Xianid");
            this.Property(t => t.Xianname).HasColumnName("Xianname");
            this.Property(t => t.Suozaibumen).HasColumnName("Suozaibumen");
            this.Property(t => t.Gangweijibie).HasColumnName("Gangweijibie");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Zuoji).HasColumnName("Zuoji");
            this.Property(t => t.Lianxidizhi).HasColumnName("Lianxidizhi");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.Workstate).HasColumnName("Workstate");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Workyears).HasColumnName("Workyears");
            this.Property(t => t.Hasboys).HasColumnName("Hasboys");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.ToFesid).HasColumnName("ToFesid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ErrorMsg).HasColumnName("ErrorMsg");
            this.Property(t => t.Flable).HasColumnName("Flable");
            this.Property(t => t.Fesable).HasColumnName("Fesable");
            this.Property(t => t.Onsitable).HasColumnName("Onsitable");
            this.Property(t => t.Checkable).HasColumnName("Checkable");
            this.Property(t => t.Midicalable).HasColumnName("Midicalable");
        }
    }
}
