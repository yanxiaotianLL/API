using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_DiaochaMap : EntityTypeConfiguration<Hm_Diaocha>
    {
        public Hm_DiaochaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Idx, t.Title, t.Qst, t.Hits, t.State });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Idx)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Qst)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Hits)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Hm_Diaocha");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Idx).HasColumnName("Idx");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Qst).HasColumnName("Qst");
            this.Property(t => t.Hits).HasColumnName("Hits");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
