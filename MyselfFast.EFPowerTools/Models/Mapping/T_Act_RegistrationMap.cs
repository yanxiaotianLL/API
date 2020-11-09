using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Act_RegistrationMap : EntityTypeConfiguration<T_Act_Registration>
    {
        public T_Act_RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Userid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Age)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

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
                .HasMaxLength(200);

            this.Property(t => t.Input5)
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

            this.Property(t => t.Realname)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Input6)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aliay_Url)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Fenday)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Payed)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Payway)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Totalpay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Selfpay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pic2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Act_Registration");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Activeid).HasColumnName("Activeid");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Pubtime).HasColumnName("Pubtime");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Comname).HasColumnName("Comname");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Input1).HasColumnName("Input1");
            this.Property(t => t.Input2).HasColumnName("Input2");
            this.Property(t => t.Input3).HasColumnName("Input3");
            this.Property(t => t.Input4).HasColumnName("Input4");
            this.Property(t => t.Input5).HasColumnName("Input5");
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
            this.Property(t => t.Realname).HasColumnName("Realname");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Input6).HasColumnName("Input6");
            this.Property(t => t.Aliay_Url).HasColumnName("Aliay_Url");
            this.Property(t => t.Fenday).HasColumnName("Fenday");
            this.Property(t => t.Isdel).HasColumnName("Isdel");
            this.Property(t => t.Payed).HasColumnName("Payed");
            this.Property(t => t.Payway).HasColumnName("Payway");
            this.Property(t => t.Personnum).HasColumnName("Personnum");
            this.Property(t => t.Totalpay).HasColumnName("Totalpay");
            this.Property(t => t.Selfpay).HasColumnName("Selfpay");
            this.Property(t => t.Pic1).HasColumnName("Pic1");
            this.Property(t => t.Pic2).HasColumnName("Pic2");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
        }
    }
}
