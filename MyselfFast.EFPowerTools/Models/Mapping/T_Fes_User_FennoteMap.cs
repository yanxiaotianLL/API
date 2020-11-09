using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_FennoteMap : EntityTypeConfiguration<T_Fes_User_Fennote>
    {
        public T_Fes_User_FennoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Uno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Cause)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Oper)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PayStates)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTime)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ProtocolType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Fennote");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.Uno).HasColumnName("Uno");
            this.Property(t => t.Aid).HasColumnName("Aid");
            this.Property(t => t.Pcid).HasColumnName("Pcid");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.FenTag).HasColumnName("FenTag");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Causeid).HasColumnName("Causeid");
            this.Property(t => t.Cause).HasColumnName("Cause");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.LmtSatrt).HasColumnName("LmtSatrt");
            this.Property(t => t.LmtEnd).HasColumnName("LmtEnd");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
            this.Property(t => t.Fstate).HasColumnName("Fstate");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.Opertime).HasColumnName("Opertime");
            this.Property(t => t.IsCommit).HasColumnName("IsCommit");
            this.Property(t => t.FeesFor).HasColumnName("FeesFor");
            this.Property(t => t.TaxesPrice).HasColumnName("TaxesPrice");
            this.Property(t => t.PayStates).HasColumnName("PayStates");
            this.Property(t => t.PaymentTime).HasColumnName("PaymentTime");
            this.Property(t => t.ProtocolType).HasColumnName("ProtocolType");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Insfrom).HasColumnName("Insfrom");
            this.Property(t => t.IsSendMail).HasColumnName("IsSendMail");
            this.Property(t => t.SendMailTime).HasColumnName("SendMailTime");
        }
    }
}
