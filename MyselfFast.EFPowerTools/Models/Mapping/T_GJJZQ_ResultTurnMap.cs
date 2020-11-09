using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_ResultTurnMap : EntityTypeConfiguration<T_GJJZQ_ResultTurn>
    {
        public T_GJJZQ_ResultTurnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Sort });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Answer1)
                .HasMaxLength(2);

            this.Property(t => t.Answer2)
                .HasMaxLength(2);

            this.Property(t => t.Answer3)
                .HasMaxLength(2);

            this.Property(t => t.Answer4)
                .HasMaxLength(2);

            this.Property(t => t.Answer5)
                .HasMaxLength(2);

            this.Property(t => t.Answer6)
                .HasMaxLength(2);

            this.Property(t => t.Answer7)
                .HasMaxLength(2);

            this.Property(t => t.Answer8)
                .HasMaxLength(2);

            this.Property(t => t.Turn)
                .HasMaxLength(100);

            this.Property(t => t.Sort)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_ResultTurn");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Answer1).HasColumnName("Answer1");
            this.Property(t => t.Answer2).HasColumnName("Answer2");
            this.Property(t => t.Answer3).HasColumnName("Answer3");
            this.Property(t => t.Answer4).HasColumnName("Answer4");
            this.Property(t => t.Answer5).HasColumnName("Answer5");
            this.Property(t => t.Answer6).HasColumnName("Answer6");
            this.Property(t => t.Answer7).HasColumnName("Answer7");
            this.Property(t => t.Answer8).HasColumnName("Answer8");
            this.Property(t => t.Turn).HasColumnName("Turn");
            this.Property(t => t.Sort).HasColumnName("Sort");
        }
    }
}
