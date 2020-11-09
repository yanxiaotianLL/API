using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_User_Fennote_ins_tailMap : EntityTypeConfiguration<T_Fes_User_Fennote_ins_tail>
    {
        public T_Fes_User_Fennote_ins_tailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.batch)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CardID)
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

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

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

            // Table & Column Mappings
            this.ToTable("T_Fes_User_Fennote_ins_tail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.FenType).HasColumnName("FenType");
            this.Property(t => t.Fno).HasColumnName("Fno");
            this.Property(t => t.Fesid).HasColumnName("Fesid");
            this.Property(t => t.batch).HasColumnName("batch");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CardID).HasColumnName("CardID");
            this.Property(t => t.Optype).HasColumnName("Optype");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.Opcause).HasColumnName("Opcause");
            this.Property(t => t.Fenlimit).HasColumnName("Fenlimit");
            this.Property(t => t.Bak).HasColumnName("Bak");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
            this.Property(t => t.ProtocolType).HasColumnName("ProtocolType");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FeesFor).HasColumnName("FeesFor");
            this.Property(t => t.TaxesPrice).HasColumnName("TaxesPrice");
            this.Property(t => t.PayStates).HasColumnName("PayStates");
            this.Property(t => t.PaymentTime).HasColumnName("PaymentTime");
        }
    }
}
