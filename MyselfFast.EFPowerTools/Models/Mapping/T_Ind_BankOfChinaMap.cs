using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_BankOfChinaMap : EntityTypeConfiguration<T_Ind_BankOfChina>
    {
        public T_Ind_BankOfChinaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.ReceiveAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PostCode)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("T_Ind_BankOfChina");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FseId).HasColumnName("FseId");
            this.Property(t => t.CardStatus).HasColumnName("CardStatus");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
            this.Property(t => t.CardNumberIsValid).HasColumnName("CardNumberIsValid");
            this.Property(t => t.TransactionMode).HasColumnName("TransactionMode");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.ReceiveAddress).HasColumnName("ReceiveAddress");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
        }
    }
}
