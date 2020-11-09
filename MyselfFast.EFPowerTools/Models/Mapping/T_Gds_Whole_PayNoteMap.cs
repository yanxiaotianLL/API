using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Gds_Whole_PayNoteMap : EntityTypeConfiguration<T_Gds_Whole_PayNote>
    {
        public T_Gds_Whole_PayNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AccountNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FenStans)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("T_Gds_Whole_PayNote");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Orderid).HasColumnName("Orderid");
            this.Property(t => t.Payid).HasColumnName("Payid");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.Fentype).HasColumnName("Fentype");
            this.Property(t => t.FenTypeName).HasColumnName("FenTypeName");
            this.Property(t => t.FenStans).HasColumnName("FenStans");
            this.Property(t => t.Fen).HasColumnName("Fen");
            this.Property(t => t.Backfen).HasColumnName("Backfen");
        }
    }
}
