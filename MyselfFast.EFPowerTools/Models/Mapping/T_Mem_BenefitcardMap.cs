using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Mem_BenefitcardMap : EntityTypeConfiguration<T_Mem_Benefitcard>
    {
        public T_Mem_BenefitcardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Cardnum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cardbak)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cardpass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cardbumen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fname)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.CardType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.YewubuUser)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProtocolType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayStates)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Optype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Opcause)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Mem_Benefitcard");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Cardnum).HasColumnName("Cardnum");
            this.Property(t => t.Cardbak).HasColumnName("Cardbak");
            this.Property(t => t.Cardpass).HasColumnName("Cardpass");
            this.Property(t => t.Cardstatus).HasColumnName("Cardstatus");
            this.Property(t => t.Cardbumen).HasColumnName("Cardbumen");
            this.Property(t => t.Chushijifen).HasColumnName("Chushijifen");
            this.Property(t => t.Jifencur).HasColumnName("Jifencur");
            this.Property(t => t.Enddate).HasColumnName("Enddate");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.Inertdate).HasColumnName("Inertdate");
            this.Property(t => t.Bddate).HasColumnName("Bddate");
            this.Property(t => t.Fname).HasColumnName("Fname");
            this.Property(t => t.busiCustId).HasColumnName("busiCustId");
            this.Property(t => t.acceId).HasColumnName("acceId");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.YewubuUser).HasColumnName("YewubuUser");
            this.Property(t => t.ProtocolType).HasColumnName("ProtocolType");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FeesFor).HasColumnName("FeesFor");
            this.Property(t => t.TaxesPrice).HasColumnName("TaxesPrice");
            this.Property(t => t.PayStates).HasColumnName("PayStates");
            this.Property(t => t.PaymentTime).HasColumnName("PaymentTime");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.Opcause).HasColumnName("Opcause");
            this.Property(t => t.Bak).HasColumnName("Bak");
        }
    }
}
