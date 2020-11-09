using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_words_fesnewtestMap : EntityTypeConfiguration<T_Exm_words_fesnewtest>
    {
        public T_Exm_words_fesnewtestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.ProjectId, t.Fid, t.Year, t.Word, t.Sort, t.OrderNo });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Word)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.Sort)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_Exm_words_fesnewtest");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Word).HasColumnName("Word");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
        }
    }
}
