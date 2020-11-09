using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Fes_QuestionMap : EntityTypeConfiguration<T_Fes_Question>
    {
        public T_Fes_QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Script)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("T_Fes_Question");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Script).HasColumnName("Script");
        }
    }
}
