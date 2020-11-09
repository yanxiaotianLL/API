using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class V_Fes_User_Fennote_ins_tailMap : EntityTypeConfiguration<V_Fes_User_Fennote_ins_tail>
    {
        public V_Fes_User_Fennote_ins_tailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fid, t.FenType, t.Fno, t.Fesid, t.batch, t.State, t.CardID, t.Optype, t.Fen, t.Opcause, t.Fenlimit, t.Bak, t.OperId, t.OperName, t.ImportTime, t.ProtocolType, t.BillType, t.FeesFor, t.TaxesPrice, t.PayStates, t.PaymentTime, t.Hno, t.Cname, t.Ename, t.Usedname, t.Gno, t.Expr1, t.Mobile });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FenType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fno)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Fesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.batch)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Optype)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Fen)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Opcause)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Bak)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ProtocolType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FeesFor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TaxesPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayStates)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentTime)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Hno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Expr1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("V_Fes_User_Fennote_ins_tail");
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
            this.Property(t => t.Hno).HasColumnName("Hno");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.Ename).HasColumnName("Ename");
            this.Property(t => t.Usedname).HasColumnName("Usedname");
            this.Property(t => t.Gno).HasColumnName("Gno");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
