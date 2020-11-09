using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_Fls_FennoteMap : EntityTypeConfiguration<T_Fes_Fls_Fennote>
    {
        public T_Fes_Fls_FennoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Cause)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Oper)
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
                .HasMaxLength(100);

            this.Property(t => t.Optype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Opcause)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Pcid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Fes_Fls_Fennote");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.MnyPay).HasColumnName("MnyPay");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.Fprice).HasColumnName("Fprice");
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
            this.Property(t => t.ProtocolType).HasColumnName("ProtocolType");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FeesFor).HasColumnName("FeesFor");
            this.Property(t => t.TaxesPrice).HasColumnName("TaxesPrice");
            this.Property(t => t.PayStates).HasColumnName("PayStates");
            this.Property(t => t.PaymentTime).HasColumnName("PaymentTime");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.Opcause).HasColumnName("Opcause");
            this.Property(t => t.Pcid).HasColumnName("Pcid");
        }
    }
}
