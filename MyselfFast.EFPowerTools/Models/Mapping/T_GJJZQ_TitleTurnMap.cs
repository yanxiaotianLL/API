using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_TitleTurnMap : EntityTypeConfiguration<T_GJJZQ_TitleTurn>
    {
        public T_GJJZQ_TitleTurnMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TitleExplain)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Answer)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.AnswerExplain)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WarmPrompt)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_TitleTurn");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TitleNo).HasColumnName("TitleNo");
            this.Property(t => t.TitleExplain).HasColumnName("TitleExplain");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.AnswerExplain).HasColumnName("AnswerExplain");
            this.Property(t => t.Turn).HasColumnName("Turn");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.WarmPrompt).HasColumnName("WarmPrompt");
        }
    }
}
