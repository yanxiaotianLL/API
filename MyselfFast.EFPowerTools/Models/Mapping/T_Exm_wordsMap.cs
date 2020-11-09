using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Exm_wordsMap : EntityTypeConfiguration<T_Exm_words>
    {
        public T_Exm_wordsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Word)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.MapPing)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Exm_words");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Fid).HasColumnName("Fid");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Word).HasColumnName("Word");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.MapPing).HasColumnName("MapPing");
        }
    }
}
