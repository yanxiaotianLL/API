using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_GJJZQ_AnswerListMap : EntityTypeConfiguration<T_GJJZQ_AnswerList>
    {
        public T_GJJZQ_AnswerListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Answer)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("T_GJJZQ_AnswerList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.TitleNo).HasColumnName("TitleNo");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.Turn).HasColumnName("Turn");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
        }
    }
}
