using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class Hm_HlrviststMap : EntityTypeConfiguration<Hm_Hlrvistst>
    {
        public Hm_HlrviststMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Visistname, t.Pass, t.Thispasscode, t.Gendate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Visistname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Pass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Thispasscode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hm_Hlrvistst");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Visistname).HasColumnName("Visistname");
            this.Property(t => t.Pass).HasColumnName("Pass");
            this.Property(t => t.Thispasscode).HasColumnName("Thispasscode");
            this.Property(t => t.Gendate).HasColumnName("Gendate");
        }
    }
}
